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
using EPollingSystem.Models;

namespace EPollingSystem.UI
{
    public partial class SeatForm : Form
    {
        public SeatForm()
        {
            InitializeComponent();
        }

        private void showSeatsButton_Click(object sender, EventArgs e)
        {
            if(selectDistrictComboBox.SelectedItem != null)
            {
                seatGrid.DataSource = SeatHandler.GetViewAbleSeats(selectDistrictComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Select district first.");
            }

        }

        private void SeatForm_Load(object sender, EventArgs e)
        {
            List<ViewAbleDistricts> viewDistrict = DistrictHandler.GetViewAbleDistricts();
            foreach(ViewAbleDistricts vdist in viewDistrict)
            {
                addSeatComboBox.Items.Add(vdist.DistrictName);
                selectDistrictComboBox.Items.Add(vdist.DistrictName);
            }
        }

        private void SeatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void deleteSeatButton_Click(object sender, EventArgs e)
        {
            if (seatGrid.DataSource != null)
            {
                int rowIndex = seatGrid.CurrentRow.Index;
                string sname = seatGrid.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to delete seat '{0}' from the database?", sname), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SeatHandler.DeleteSeat(sname);
                    MessageBox.Show("Deleted");
                    seatGrid.DataSource = SeatHandler.GetViewAbleSeats(selectDistrictComboBox.SelectedItem.ToString());
                }
            }
        }

        private void addSeatButton_Click(object sender, EventArgs e)
        {
            if (addSeatTextBox.Text != "" && addSeatComboBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to add seat '{0}' under district '{1}' to the database?", addSeatTextBox.Text, addSeatComboBox.SelectedItem), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (SeatHandler.AddSeat(addSeatTextBox.Text, addSeatComboBox.SelectedItem.ToString()))
                        MessageBox.Show("Successfully added seat.");
                    else
                        MessageBox.Show("Seat name already present.");
                    addSeatTextBox.Text = "";
                    seatGrid.DataSource = SeatHandler.GetViewAbleSeats(addSeatComboBox.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Enter a seat name and select a district.");
            }
        }

        private void selectDistrictComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            seatGrid.DataSource = null;
        }
    }
}
