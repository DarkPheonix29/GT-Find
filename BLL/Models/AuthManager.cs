using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class AuthManager
    {
        public static bool AuthenticateUser(string username, string password)
        {
            using (var connection = ConnectionString.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Username = @Username AND Password = @Password", connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", EncryptPassword(password));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private static string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
