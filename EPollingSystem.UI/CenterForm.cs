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
    public partial class CenterForm : Form
    {
        public CenterForm()
        {
            InitializeComponent();
        }

        private void CenterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void CenterForm_Load(object sender, EventArgs e)
        {
            List<ViewAbleDistricts> viewDistricts = DistrictHandler.GetViewAbleDistricts();
            foreach(ViewAbleDistricts vdist in viewDistricts)
            {
                districtComboBox.Items.Add(vdist.DistrictName);
                selectDistrictComboBox.Items.Add(vdist.DistrictName);
            }
        }

        private void showCenterButton_Click(object sender, EventArgs e)
        {
            if(selectSeatComboBox.SelectedItem != null)
            {
                centerGrid.DataSource = CenterHandler.GetViewAbleCenters(selectSeatComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select seat first.");
            }
        }

        private void selectDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectSeatComboBox.Items.Clear();
            List<ViewAbleSeats> viewSeats = SeatHandler.GetViewAbleSeats(selectDistrictComboBox.SelectedItem.ToString());
            foreach(ViewAbleSeats vseat in viewSeats)
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

        private void deleteCenterButton_Click(object sender, EventArgs e)
        {
            if(centerGrid.DataSource != null)
            {
                int rowIndex = centerGrid.CurrentRow.Index;
                string centerName = centerGrid.Rows[rowIndex].Cells[1].Value.ToString();
                int id = int.Parse(centerGrid.Rows[rowIndex].Cells[0].Value.ToString());
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to delete center '{0}' from the database?", centerName), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CenterHandler.DeleteCenter(id);
                    centerGrid.DataSource = CenterHandler.GetViewAbleCenters(selectSeatComboBox.SelectedItem.ToString());
                }  
            }
        }

        private void addCenterButton_Click(object sender, EventArgs e)
        {
            if(centerTextBox.Text != "" && agentTextBox.Text != "" && seatComboBox.SelectedItem != null && passwordTextBox.Text != null && confirmPasswordTextBox.Text != null)
            {
                if(passwordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    DialogResult dr = MessageBox.Show(string.Format("Are you sure to add center '{0}' with agent '{1}' under seat '{2}' to the database?", centerTextBox.Text, agentTextBox.Text,seatComboBox.SelectedItem.ToString()), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (CenterHandler.AddCenter(centerTextBox.Text, agentTextBox.Text, passwordTextBox.Text, seatComboBox.SelectedItem.ToString()))
                            MessageBox.Show("Successfully added center.");
                        else
                            MessageBox.Show("Center already present.");
                        centerGrid.DataSource = CenterHandler.GetViewAbleCenters(seatComboBox.SelectedItem.ToString());
                        centerTextBox.Text = "";
                        agentTextBox.Text = "";
                        passwordTextBox.Text = "";
                        confirmPasswordTextBox.Text = "";
                        
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all the fields.");
            }
        }
    }
}
