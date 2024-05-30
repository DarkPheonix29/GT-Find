using BLL.Models;
using BLL.Validators;
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
        public List<string> ValidCountries { get; set; } = Validator.GetValidCountries();
        public List<string> ValidRegions { get; set; } = Validator.GetValidRegions();
        public List<string> ValidPlatforms { get; set; } = Validator.GetValidPlatforms();

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

        public ProfileInfo ToProfileInfo(int userId, string username)
        {
            return new ProfileInfo(
                userId,
                username,
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
    }
}
