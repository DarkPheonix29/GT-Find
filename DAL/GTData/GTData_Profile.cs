using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.IGTData;
using BLL.Models;

namespace DAL
{
    public class GTData_Profile : IGTProfileData
    {
        public bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue)
        {
            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();

                    // Check if a profile for the given user ID already exists
                    string checkQuery = "SELECT COUNT(*) FROM Profile WHERE UserID = @UserID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@UserID", userId);
                    int profileCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (profileCount > 0)
                    {
                        // Profile exists, so update it
                        string updateQuery = "UPDATE Profile SET Username = @Username, Bio = @Bio, Region = @Region, Country = @Country, Platform = @Platform, Fun = @Fun, Competitive = @Competitive, Serious = @Serious, Communication = @Communication, Dedication = @Dedication WHERE UserID = @UserID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@UserID", userId);
                        updateCmd.Parameters.AddWithValue("@Username", User.Username);
                        updateCmd.Parameters.AddWithValue("@Bio", bio);
                        updateCmd.Parameters.AddWithValue("@Region", region);
                        updateCmd.Parameters.AddWithValue("@Country", country);
                        updateCmd.Parameters.AddWithValue("@Platform", platform);
                        updateCmd.Parameters.AddWithValue("@Fun", funValue);
                        updateCmd.Parameters.AddWithValue("@Competitive", copValue);
                        updateCmd.Parameters.AddWithValue("@Serious", srsValue);
                        updateCmd.Parameters.AddWithValue("@Communication", comValue);
                        updateCmd.Parameters.AddWithValue("@Dedication", dedValue);

                        Debug.WriteLine("Executing SQL query: " + updateCmd.CommandText);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    else
                    {
                        // Profile doesn't exist, so insert a new one
                        string insertQuery = "INSERT INTO Profile (UserID, Username, Bio, Region, Country, Platform, Fun, Competitive, Serious, Communication, Dedication) VALUES (@UserID, @Bio, @Region, @Country, @Platform, @Fun, @Competitive, @Serious, @Communication, @Dedication)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@UserID", userId);
                        insertCmd.Parameters.AddWithValue("@Username", User.Username);
                        insertCmd.Parameters.AddWithValue("@Bio", bio);
                        insertCmd.Parameters.AddWithValue("@Region", region);
                        insertCmd.Parameters.AddWithValue("@Country", country);
                        insertCmd.Parameters.AddWithValue("@Platform", platform);
                        insertCmd.Parameters.AddWithValue("@Fun", funValue);
                        insertCmd.Parameters.AddWithValue("@Competitive", copValue);
                        insertCmd.Parameters.AddWithValue("@Serious", srsValue);
                        insertCmd.Parameters.AddWithValue("@Communication", comValue);
                        insertCmd.Parameters.AddWithValue("@Dedication", dedValue);

                        Debug.WriteLine("Executing SQL query: " + insertCmd.CommandText);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }


        public ProfileInfo RetrieveProfile(int userId)
        {
            ProfileInfo profileInfo = new ProfileInfo();

            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT Bio, Region, Country, Platform, Fun, Competitive, Serious, Communication, Dedication FROM Profile WHERE UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            profileInfo.Bio = reader.GetString("Bio");
                            profileInfo.Region = reader.GetString("Region");
                            profileInfo.Country = reader.GetString("Country");
                            profileInfo.Platform = reader.GetString("Platform");
                            profileInfo.Fun = reader.GetInt32("Fun");
                            profileInfo.Competitive = reader.GetInt32("Competitive");
                            profileInfo.Serious = reader.GetInt32("Serious");
                            profileInfo.Communication = reader.GetInt32("Communication");
                            profileInfo.Dedication = reader.GetInt32("Dedication");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while retrieving profile: {ex.Message}");
            }

            return profileInfo;
        }

        public List<ProfileInfo> GetAllProfiles()
        {
            List<ProfileInfo> profiles = new List<ProfileInfo>();

            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT UserID, Username, Bio, Region, Country, Platform, Fun, Competitive, Serious, Communication, Dedication FROM Profile";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProfileInfo profile = new ProfileInfo
                            {
                                UserID = reader.GetInt32("UserID"),
                                Username = reader.GetString("Username"),
                                Bio = reader.GetString("Bio"),
                                Region = reader.GetString("Region"),
                                Country = reader.GetString("Country"),
                                Platform = reader.GetString("Platform"),
                                Fun = reader.GetInt32("Fun"),
                                Competitive = reader.GetInt32("Competitive"),
                                Serious = reader.GetInt32("Serious"),
                                Communication = reader.GetInt32("Communication"),
                                Dedication = reader.GetInt32("Dedication")
                            };

                            profiles.Add(profile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (you can replace this with your preferred logging approach)
                Console.WriteLine($"An error occurred while retrieving profiles: {ex.Message}");
            }

            return profiles;
        }

        public bool DeleteProfile(int userId)
        {
            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Profile WHERE UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while deleting profile: {ex.Message}");
                return false;
            }
        }
    }
}
