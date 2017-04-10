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
    public partial class DistrictForm : Form
    {
        public DistrictForm()
        {
            InitializeComponent();
        }

        

        private void showDistrictsButton_Click(object sender, EventArgs e)
        {
            districtGrid.DataSource = DistrictHandler.GetViewAbleDistricts();
        }

        private void addDistrictButton_Click(object sender, EventArgs e)
        {
            if (addDistrictTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to add '{0}' to the database?", addDistrictTextBox.Text), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (DistrictHandler.AddDistrict(addDistrictTextBox.Text))
                        MessageBox.Show("Successfully added district.");
                    else
                        MessageBox.Show("District name already present.");
                    addDistrictTextBox.Text = "";
                    districtGrid.DataSource = DistrictHandler.GetViewAbleDistricts();
                }
            }
            else
            {
                MessageBox.Show("Enter a district name.");
            }
        }

        private void DistrictForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void deleteDistrictButton_Click(object sender, EventArgs e)
        {
            if (districtGrid.DataSource != null)
            {
                int rowIndex = districtGrid.CurrentRow.Index;
                string dname = districtGrid.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show(string.Format("Are you sure to delete '{0}' from the database?", dname), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DistrictHandler.DeleteDistrict(dname);
                    MessageBox.Show("Deleted");
                    districtGrid.DataSource = DistrictHandler.GetViewAbleDistricts();
                }
            }
            
        }
    }
}
