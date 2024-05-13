using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Models;
using System.Diagnostics;
using System.Data;

namespace DAL
{
    public class GTData : IGTData
    {
        public event EventHandler<string> ErrorOccurred;
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
                Debug.WriteLine($"Error creating account: {ex.Message}");
                return false;
            }
        }
        public bool SaveProfile(int userId, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue)
        {
            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Profile (UserID, Bio, Region, Country, Platform, Fun, Competitive, Serious, Communication, Dedication) VALUES (@UserID, @Bio, @Region, @Country, @Platform, @Fun, @Competitive, @Serious, @Communication, @Dedication)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Bio", bio);
                    cmd.Parameters.AddWithValue("@Region", region);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Platform", platform);
                    cmd.Parameters.AddWithValue("@Fun", funValue);
                    cmd.Parameters.AddWithValue("@Competitive", copValue);
                    cmd.Parameters.AddWithValue("@Serious", srsValue);
                    cmd.Parameters.AddWithValue("@Communication", comValue);
                    cmd.Parameters.AddWithValue("@Dedication", dedValue);

                    // Log the filled-in SQL query
                    Debug.WriteLine("Executing SQL query: " + cmd.CommandText);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        public int RetrieveUserId(string username)
        {
            int userId = -1;

            using (MySqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UserID FROM account WHERE Username = @Username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error retrieving user ID: {ex.Message}");
                }
            }

            return userId;
        }
    }
}
