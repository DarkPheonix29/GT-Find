using BLL;
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
        public Login()
        {
            InitializeComponent();
        }

        private void gotohomepage(object sender, EventArgs e)
        {
            string username = userlogtext.Text;
            string password = passlogtxt.Text;


            string hashedPasswordFromDatabase = RetrievePass(username);

 
            if (!string.IsNullOrEmpty(hashedPasswordFromDatabase))
            {

                if (AuthManager.ValidateUser(password, hashedPasswordFromDatabase))
                {
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

        private string RetrievePass(string username)
        {
            {
                string hashedPassword = null;

                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Password FROM account WHERE Username = @Username";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", username);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                hashedPassword = reader.GetString("Password");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving hashed password: {ex.Message}");
                    }
                }

                return hashedPassword;
            }
        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
