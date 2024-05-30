using BLL;
using BLL.Models;
using DAL;
using GT_Find.Lay_outs;
using System;
using System.Windows.Forms;

namespace GT_Find
{
    public partial class Login : Form
    {
        private readonly GTService gtService; // Declare GTService instance

        public Login()
        {
            InitializeComponent();
            this.gtService = new GTService(new GTData_Account(), new GTData_Profile(), new GTData_Games()); // Initialize GTService instance
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
                    // Set the username and user ID in the UserSession class
                    UserSession.CurrentUser = new User(username, gtService.RetrieveUserId(username));

                    MessageBox.Show("Login successful!");

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
