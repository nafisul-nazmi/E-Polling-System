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
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
        }

        private void showTeamsButton_Click(object sender, EventArgs e)
        {
            teamGrid.DataSource = TeamHandler.GetViewAbleTeams();
        }

        private void TeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            if (teamNameTextBox.Text != "" && teamSymbolTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to add team '{0}' with symbol '{1}' to the database?", teamNameTextBox.Text, teamSymbolTextBox.Text), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (TeamHandler.AddTeam(teamNameTextBox.Text, teamSymbolTextBox.Text))
                        MessageBox.Show("Successfully added team.");
                    else
                        MessageBox.Show("Unique team name and symbols should be entered.");
                    teamSymbolTextBox.Text = "";
                    teamNameTextBox.Text = "";
                    teamGrid.DataSource = TeamHandler.GetViewAbleTeams();
                }
            }
            else
            {
                MessageBox.Show("Enter team name and symbol.");
            }
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            if (teamGrid.DataSource != null)
            {
                int rowIndex = teamGrid.CurrentRow.Index;
                string teamName = teamGrid.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to delete '{0}' from the database?", teamName), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    TeamHandler.DeleteTeam(teamName);
                    MessageBox.Show("Deleted");
                    teamGrid.DataSource = TeamHandler.GetViewAbleTeams();
                }
            }
        }
    }
}
