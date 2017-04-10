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
    public partial class CandidateForm : Form
    {
        public CandidateForm()
        {
            InitializeComponent();
        }

        private void CandidateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void CandidateForm_Load(object sender, EventArgs e)
        {
            List<ViewAbleTeams> vTeams = TeamHandler.GetViewAbleTeams();
            List<ViewAbleDistricts> vDists = DistrictHandler.GetViewAbleDistricts();
            foreach(ViewAbleTeams vteam in vTeams)
            {
                teamComboBox.Items.Add(vteam.TeamName);
            }
            foreach(ViewAbleDistricts vdist in vDists)
            {
                selectDistrictComboBox.Items.Add(vdist.DistrictName);
                districtComboBox.Items.Add(vdist.DistrictName);
            }
        }

        private void selectDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectSeatComboBox.Items.Clear();
            List<ViewAbleSeats> viewSeats = SeatHandler.GetViewAbleSeats(selectDistrictComboBox.SelectedItem.ToString());
            foreach (ViewAbleSeats vseat in viewSeats)
            {
                selectSeatComboBox.Items.Add(vseat.SeatName);
            }
        }

        private void districtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatComboBox.Items.Clear();
            List<ViewAbleSeats> viewSeats = SeatHandler.GetViewAbleSeats(districtComboBox.SelectedItem.ToString());
            foreach (ViewAbleSeats vseat in viewSeats)
            {
                seatComboBox.Items.Add(vseat.SeatName);
            }
        }

        private void showCandidateButton_Click(object sender, EventArgs e)
        {
            if(selectSeatComboBox.SelectedItem != null)
            {
                candidateGrid.DataSource = CandidateHandler.GetViewAbleCandidatesAdmin(selectSeatComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select seat.");
            }
        }

        private void addCandidateButton_Click(object sender, EventArgs e)
        {
            if (candidateNameTextBox.Text != "" && teamComboBox.SelectedItem != null && districtComboBox.SelectedItem != null && seatComboBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to add candidate '{0}' from team '{1}' in seat '{2}'?", candidateNameTextBox.Text, teamComboBox.SelectedItem.ToString(), seatComboBox.SelectedItem.ToString()), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (CandidateHandler.AddCandidate(candidateNameTextBox.Text, seatComboBox.SelectedItem.ToString(), teamComboBox.SelectedItem.ToString()))
                        MessageBox.Show("Successfully added candidate.");
                    else
                        MessageBox.Show("Candidate from the team already present.");
                    candidateNameTextBox.Text = "";
                    candidateGrid.DataSource = CandidateHandler.GetViewAbleCandidatesAdmin(seatComboBox.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Enter the values properly.");
            }
        }

        private void deleteCandidateButton_Click(object sender, EventArgs e)
        {
            if (candidateGrid.DataSource != null)
            {
                int rowIndex = candidateGrid.CurrentRow.Index;
                string candidateName = candidateGrid.Rows[rowIndex].Cells[1].Value.ToString();
                string seatName = candidateGrid.Rows[rowIndex].Cells[2].Value.ToString();
                string teamName = candidateGrid.Rows[rowIndex].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to delete candidate '{0}' from team '{1}'from the database?", candidateName, teamName), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CandidateHandler.DeleteCandidate(candidateName, seatName, teamName);
                    MessageBox.Show("Deleted");
                    candidateGrid.DataSource = CandidateHandler.GetViewAbleCandidatesAdmin(seatName);
                }
            }
        }
    }
}
