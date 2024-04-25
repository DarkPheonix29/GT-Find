using BLL;
using GT_Find.Lay_outs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_Find
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gotohomepage(object sender, EventArgs e)
        {

            string username = emailtext.Text;
            string password = passtxt.Text;

            if (AuthManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Redirect or perform necessary actions after successful login
                Home home = new Home();

                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
