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
    public partial class VoterForm : Form
    {
        public VoterForm()
        {
            InitializeComponent();
        }

        private void VoterForm_Load(object sender, EventArgs e)
        {
            List<ViewAbleDistricts> viewDist = DistrictHandler.GetViewAbleDistricts();
            foreach(ViewAbleDistricts vDist in viewDist)
            {
                selectDistrcitComboBox.Items.Add(vDist.DistrictName);
                districtComboBox.Items.Add(vDist.DistrictName);
            }
        }

        private void selectDistrcitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectSeatComboBox.Items.Clear();
            if (selectDistrcitComboBox.SelectedItem != null)
            {
                List<ViewAbleSeats> viewSeat = SeatHandler.GetViewAbleSeats(selectDistrcitComboBox.SelectedItem.ToString());
                foreach(ViewAbleSeats vSeat in viewSeat)
                {
                    selectSeatComboBox.Items.Add(vSeat.SeatName);
                }
            }
        }

        private void districtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatComboBox.Items.Clear();
            if (districtComboBox.SelectedItem != null)
            {
                List<ViewAbleSeats> viewSeat = SeatHandler.GetViewAbleSeats(districtComboBox.SelectedItem.ToString());
                foreach (ViewAbleSeats vSeat in viewSeat)
                {
                    seatComboBox.Items.Add(vSeat.SeatName);
                }
            }
        }

        private void selectSeatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCenterComboBox.Items.Clear();
            if(selectSeatComboBox.SelectedItem != null)
            {
                List<ViewAbleCenters> viewCenter = CenterHandler.GetViewAbleCenters(selectSeatComboBox.SelectedItem.ToString());
                foreach(ViewAbleCenters vCenter in viewCenter)
                {
                    selectCenterComboBox.Items.Add(vCenter.CenterName);

                }
            }
        }

        private void seatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            centerComboBox.Items.Clear();
            if (seatComboBox.SelectedItem != null)
            {
                List<ViewAbleCenters> viewCenter = CenterHandler.GetViewAbleCenters(seatComboBox.SelectedItem.ToString());
                foreach (ViewAbleCenters vCenter in viewCenter)
                {
                    centerComboBox.Items.Add(vCenter.CenterName);

                }
            }
        }

        private void showVoterButton_Click(object sender, EventArgs e)
        {
            if(selectSeatComboBox.SelectedItem != null && selectCenterComboBox.SelectedItem != null)
            {
                voterGrid.DataSource = VoterHandler.GetVoters(selectSeatComboBox.SelectedItem.ToString(), selectCenterComboBox.SelectedItem.ToString());

            }
            else
            {
                MessageBox.Show("Select Center.");
            }
        }

        private void addVoterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(nIdTextBox.Text != "" && centerComboBox.SelectedItem != null && seatComboBox.SelectedItem != null)
                {
                    DialogResult dr = MessageBox.Show(string.Format("Are you sure to add voter with NID '{0}' under center '{1}'?", nIdTextBox.Text, centerComboBox.SelectedItem.ToString()), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        long nId = long.Parse(nIdTextBox.Text);
                        if (VoterHandler.AddVoter(nId, seatComboBox.SelectedItem.ToString(), centerComboBox.SelectedItem.ToString()))
                        {
                            MessageBox.Show("Successfully added voter.");
                            voterGrid.DataSource = VoterHandler.GetVoters(seatComboBox.SelectedItem.ToString(), centerComboBox.SelectedItem.ToString());
                        }
                        else
                            MessageBox.Show("Voter already present.");
                        
                        nIdTextBox.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Enter Information Properly.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter NID properly.");
            }
        }

        private void deleteVoterButton_Click(object sender, EventArgs e)
        {
            if(voterGrid.DataSource != null)
            {
                int rowIndex = voterGrid.CurrentRow.Index;
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to delete voter '{0}' from the database?", voterGrid.Rows[rowIndex].Cells[0].Value.ToString()), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    long nid = long.Parse(voterGrid.Rows[rowIndex].Cells[0].Value.ToString());
                    VoterHandler.DeleteVoter(nid);
                    voterGrid.DataSource = VoterHandler.GetVoters(selectSeatComboBox.SelectedItem.ToString(), selectCenterComboBox.SelectedItem.ToString());


                }

            }
            else
            {
                MessageBox.Show("Select item to delete.");
            }
        }

        private void VoterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }
    }
}
