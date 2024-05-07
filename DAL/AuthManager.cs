using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class AuthManager
    {
        public static bool ValidateUser(string passwordtext, string databaseHash)
        {
            return BCrypt.Net.BCrypt.Verify(passwordtext, databaseHash);
        }


        public static string SecurePassword(string passwordtext)
        {
            return BCrypt.Net.BCrypt.HashPassword(passwordtext);
        }
    }
}
