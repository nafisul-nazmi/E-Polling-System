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
    public partial class BlockForm : Form
    {
        public BlockForm()
        {
            InitializeComponent();
        }

        private void BlockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void BlockForm_Load(object sender, EventArgs e)
        {
            List<ViewAbleDistricts> viewDistricts = DistrictHandler.GetViewAbleDistricts();
            foreach (ViewAbleDistricts vdist in viewDistricts)
            {
                districtComboBox.Items.Add(vdist.DistrictName);
                
            }
        }

        private void districtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatComboBox.Items.Clear();
            List<ViewAbleSeats> viewSeat = SeatHandler.GetViewAbleSeats(districtComboBox.SelectedItem.ToString());
            foreach(ViewAbleSeats vseat in viewSeat)
            {
                seatComboBox.Items.Add(vseat.SeatName);
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            blockGrid.DataSource = CenterHandler.GetBlockedCenters();
        }

        private void showSelectecButton_Click(object sender, EventArgs e)
        {
            if(seatComboBox.SelectedItem != null)
            {
                blockGrid.DataSource = CenterHandler.GetBlockedCenters(seatComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a seat.");
            }
        }

        private void unblockButton_Click(object sender, EventArgs e)
        {
            if (blockGrid.DataSource != null)
            {
                int rowIndex = blockGrid.CurrentRow.Index;
                int centerId = int.Parse(blockGrid.Rows[rowIndex].Cells[0].Value.ToString());
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to unblock center '{0}'?", blockGrid.Rows[rowIndex].Cells[1].Value.ToString()), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CenterHandler.UnblockCenter(centerId);
                    blockGrid.DataSource = CenterHandler.GetBlockedCenters();
                }
            }
        }
    }
}
