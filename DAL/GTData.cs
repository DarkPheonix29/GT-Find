using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class GTData : IGTData
    {
        public string RetrievePass(string username)
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

        public bool CreateAccount(string email, string hashedPassword, string username)
        {
            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO account (Email, Password, Username) VALUES (@Email, @Password, @Username)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating account: {ex.Message}");
                return false;
            }
        }
    }
}
