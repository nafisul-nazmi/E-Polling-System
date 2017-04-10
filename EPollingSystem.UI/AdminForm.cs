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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        

        private void manageDistrictButton_Click(object sender, EventArgs e)
        {
            DistrictForm distForm = new DistrictForm();
            distForm.Show();
            distForm.Owner = this;
            Hide();
            
        }

        private void manageTeamsButton_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            teamForm.Owner = this;
            Hide();
            teamForm.Show();
        }

        private void manageSeatsButton_Click(object sender, EventArgs e)
        {
            SeatForm seatForm = new SeatForm();
            seatForm.Owner = this;
            Hide();
            seatForm.Show();
        }

        private void manageCentersButton_Click(object sender, EventArgs e)
        {
            CenterForm centerForm = new CenterForm();
            centerForm.Owner = this;
            Hide();
            centerForm.Show();
        }

        private void manageCandidatesButton_Click(object sender, EventArgs e)
        {
            CandidateForm candidateForm = new CandidateForm();
            candidateForm.Owner = this;
            Hide();
            candidateForm.Show();
        }

        private void blockedCentersButton_Click(object sender, EventArgs e)
        {
            BlockForm blockform = new BlockForm();
            blockform.Owner = this;
            blockform.Show();
            Hide();
        }

        private void manageVoterButton_Click(object sender, EventArgs e)
        {
            VoterForm voterForm = new VoterForm();
            voterForm.Owner = this;
            Hide();
            voterForm.Show();
        }

        private void startElectionButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to start the election?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                CenterHandler.StartElection();
                MessageBox.Show("Election Started");
            }
        }

        private void endElectionButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to end the election?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                CenterHandler.EndElection();
                MessageBox.Show("Election Ended");
            }
        }

        private void resultGenerateButton_Click(object sender, EventArgs e)
        {
            ResultGenerator.GenerateResult();
            MessageBox.Show("Updated Result Generated. Go to Manage Candidates to see seat-wise obtained votes. Go to Teams to see total obtained seats of each team.");
        }
    }
}
