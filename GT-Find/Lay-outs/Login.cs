using BLL;
using BLL.Models;
using DAL;
using GT_Find.Lay_outs;
using MySql.Data.MySqlClient;
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
        private readonly GTService gtService; // Declare GTService instance

        public Login()
        {
            InitializeComponent();
            this.gtService = new GTService(new GTData()); // Initialize GTService instance
        }

        private void gotohomepage(object sender, EventArgs e)
        {
            string username = userlogtext.Text;
            string password = passlogtxt.Text;

            string hashedPasswordFromDatabase = gtService.RetrievePass(username); // Call RetrievePass method through gtService

            if (!string.IsNullOrEmpty(hashedPasswordFromDatabase))
            {
                if (AuthManager.ValidateUser(password, hashedPasswordFromDatabase))
                {
                    MessageBox.Show("Login successful!");
                    User.Username = username;
                    User.UserId = gtService.RetrieveUserId(username); // Retrieve and store the user ID
                    
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {
            // Whatever you want to do when email text changes
        }
    }
}
