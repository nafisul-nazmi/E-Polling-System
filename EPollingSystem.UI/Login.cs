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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userIdTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Owner = this;
                adminForm.Show();
                this.Hide();

            }
            else
            {
                try
                {
                    int id = int.Parse(userIdTextBox.Text);
                    if (LoginHandler.Verify(id, passwordTextBox.Text))
                    {
                        CenterWindow centerWindow = new CenterWindow();
                        centerWindow.Owner = this;
                        Hide();
                        centerWindow.Show();
                      
                    }
                    else
                    {
                        MessageBox.Show("Invalid user id or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid user id.");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
