using BLL.Models;
using System.Collections.Generic;

namespace GT_Web.Models
{
    public class ProfileViewModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Platform { get; set; }
        public int Fun { get; set; }
        public int Competitive { get; set; }
        public int Serious { get; set; }
        public int Communication { get; set; }
        public int Dedication { get; set; }
        public List<string> AvailableGames { get; set; }
        public List<string> SelectedGames { get; set; }

        // Conversion method from ProfileViewModel to ProfileInfo
        public ProfileInfo ToProfileInfo()
        {
            return new ProfileInfo(
                UserID,
                Username,
                Bio,
                Region,
                Country,
                Platform,
                Fun,
                Competitive,
                Serious,
                Communication,
                Dedication
            );
        }

        // Conversion method from ProfileInfo to ProfileViewModel
        public static ProfileViewModel FromProfileInfo(ProfileInfo profileInfo)
        {
            return new ProfileViewModel
            {
                UserID = profileInfo.UserID,
                Username = profileInfo.Username,
                Bio = profileInfo.Bio,
                Region = profileInfo.Region,
                Country = profileInfo.Country,
                Platform = profileInfo.Platform,
                Fun = profileInfo.Fun,
                Competitive = profileInfo.Competitive,
                Serious = profileInfo.Serious,
                Communication = profileInfo.Communication,
                Dedication = profileInfo.Dedication
            };
        }
    }
}
