using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPollingSystem.Models;
using EPollingSystem.BLL;

namespace EPollingSystem.UI
{
    public partial class VotingWindow : Form
    {
        public VotingWindow()
        {
            InitializeComponent();
        }

        private void VotingWindow_Load(object sender, EventArgs e)
        {
            int seatId = CenterHandler.GetSeatId(LoginHandler.CenterId);
            candidateGrid.DataSource = CandidateHandler.GetViewAbleCandidates(seatId);
        }

        private void VotingWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            int status = CenterHandler.GetCenterStatus(LoginHandler.CenterId);
            if (status == 1)
            {
                try
                {
                    long nId = long.Parse(nIdTextBox.Text);
                    int rowIndex = candidateGrid.CurrentRow.Index;
                    int candidateId = int.Parse(candidateGrid.Rows[rowIndex].Cells[4].Value.ToString());
                    string candidateName = candidateGrid.Rows[rowIndex].Cells[0].Value.ToString();
                    string teamName = candidateGrid.Rows[rowIndex].Cells[2].Value.ToString();
                    DialogResult dr = MessageBox.Show(string.Format("Are you sure to vote '{0}' from team '{1}'?", candidateName, teamName), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        if(VoterHandler.Voted(nId))
                        {
                            VoterHandler.Vote(candidateId);
                            MessageBox.Show("Vote counted.");
                            nIdTextBox.Text = "";
                            int seatId = CenterHandler.GetSeatId(LoginHandler.CenterId);
                            candidateGrid.DataSource = CandidateHandler.GetViewAbleCandidates(seatId);
                        }
                        else
                        {
                            MessageBox.Show("Vote not counted. Contact Polling Agent.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter NID properly.");
                }
            }
            else if(status == 2)
            {
                MessageBox.Show("Center Blocked.");
            }
            else
            {
                MessageBox.Show("Election is not going on.");
            }
        }
    }
}
