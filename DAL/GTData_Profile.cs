using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class GTData_Profile : IGTProfileData
    {
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
    }
}
