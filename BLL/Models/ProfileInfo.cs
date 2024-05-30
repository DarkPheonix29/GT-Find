using BLL.Validators;
using System;

namespace BLL.Models
{
    public class ProfileInfo
    {
        public int UserID { get; }
        public string Username { get; }
        public string Bio { get; }
        public string Region { get; }
        public string Country { get; }
        public string Platform { get; }
        public int Fun { get; }
        public int Competitive { get; }
        public int Serious { get; }
        public int Communication { get; }
        public int Dedication { get; }

        public ProfileInfo(int userId, string username, string bio, string region, string country, string platform, int fun, int competitive, int serious, int communication, int dedication)
        {
            if (!Validator.IsValidCountry(country))
            {
                throw new ArgumentException("Invalid country.");
            }
            if (!Validator.IsValidRegion(region))
            {
                throw new ArgumentException("Invalid region.");
            }
            if (!Validator.IsValidPlatform(platform))
            {
                throw new ArgumentException("Invalid platform.");
            }
            if (!Validator.IsValidRating(fun) || !Validator.IsValidRating(competitive) || !Validator.IsValidRating(serious) || !Validator.IsValidRating(communication) || !Validator.IsValidRating(dedication))
            {
                throw new ArgumentException("Ratings must be between 1 and 5.");
            }
            if (!Validator.IsValidUsername(username))
            {
                throw new ArgumentException("Username cannot be longer than 20 characters.");
            }

            UserID = userId;
            Username = username;
            Bio = bio;
            Region = region;
            Country = country;
            Platform = platform;
            Fun = fun;
            Competitive = competitive;
            Serious = serious;
            Communication = communication;
            Dedication = dedication;
        }
    }
}
