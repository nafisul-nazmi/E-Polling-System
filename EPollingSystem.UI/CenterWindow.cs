using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPollingSystem.BLL;

namespace EPollingSystem.UI
{
    public partial class CenterWindow : Form
    {
        public CenterWindow()
        {
            InitializeComponent();
        }

        private void CenterWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int status = CenterHandler.GetCenterStatus(LoginHandler.CenterId);
            if (status == 1)
            {
                if (nidTextBox.Text != "")
                {
                    try
                    {
                        long nid = long.Parse(nidTextBox.Text);
                        int voterStatus = VoterHandler.CheckStatus(nid);
                        if (voterStatus == 0)
                            MessageBox.Show("Cannot find the NID.");
                        else if (voterStatus == 1)
                            MessageBox.Show("Valid NID.");
                        else if (voterStatus == 2)
                            MessageBox.Show("Valid NID and Processed, but did not vote");
                        else if (voterStatus == 3)
                            MessageBox.Show("Vote Completed");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter proper NID.");
                    }

                }
                else
                {
                    MessageBox.Show("Enter proper NID.");
                }
            }
            else if(status == 2)
            {
                MessageBox.Show("Center is blocked.");
            }
            else
            {
                MessageBox.Show("Election is not going on currently.");
            }
        }

        private void permitButton_Click(object sender, EventArgs e)
        {
            int status = CenterHandler.GetCenterStatus(LoginHandler.CenterId);
            if (status == 1)
            {
                if (nidTextBox.Text != "")
                {
                    try
                    {
                        long nid = long.Parse(nidTextBox.Text);
                        DialogResult dr = MessageBox.Show(string.Format("Are you sure to permit voter with NID {0} to vote?", nid), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            if (VoterHandler.Permit(nid))
                                MessageBox.Show("Voter Permitted.");
                            else
                                MessageBox.Show("Voter Not Permitted. Please check status.");

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter proper NID.");
                    }

                }
                else
                {
                    MessageBox.Show("Enter proper NID.");
                }
            }
            else if(status == 2)
            {
                MessageBox.Show("Center Blocked.");
            }
            else
            {
                MessageBox.Show("Election is not going on currently.");
            }
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to block this center?",  "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LoginHandler.BlockCenter();
                MessageBox.Show("Center Blocked");
            }
        }

        private void votingWindowButton_Click(object sender, EventArgs e)
        {
            VotingWindow votingWindow = new VotingWindow();
            Hide();
            votingWindow.Show();
        }
    }
}
