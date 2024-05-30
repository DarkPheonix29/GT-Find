using BLL.IGTData;
using BLL.Models;
using BLL.Validators;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GTService : IGTService
    {
        private readonly IGTAccountData accountdata;
        private readonly IGTProfileData profiledata;
        private readonly IGTGamesData gamedata;

        public GTService(IGTAccountData accountdata, IGTProfileData profiledata, IGTGamesData gamedata)
        {
            this.accountdata = accountdata;
            this.profiledata = profiledata;
            this.gamedata = gamedata;
        }

        public string RetrievePass(string username)
        {
            return accountdata.RetrievePass(username);
        }

        public bool CreateAccount(string email, string hashedPassword, string username)
        {
            if (!Validator.IsValidUsername(username))
            {
                throw new ArgumentException("Username cannot be longer than 20 characters.");
            }

            return accountdata.CreateAccount(email, hashedPassword, username);
        }

        public bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue)
        {
            if (string.IsNullOrEmpty(username) || !Validator.IsValidUsername(username))
            {
                throw new ArgumentException("Invalid or missing username.");
            }

            if (string.IsNullOrEmpty(country) || !Validator.IsValidCountry(country))
            {
                throw new ArgumentException("Invalid or missing country.");
            }

            if (string.IsNullOrEmpty(region) || !Validator.IsValidRegion(region))
            {
                throw new ArgumentException("Invalid or missing region.");
            }

            if (string.IsNullOrEmpty(platform) || !Validator.IsValidPlatform(platform))
            {
                throw new ArgumentException("Invalid or missing platform.");
            }

            if (!Validator.IsValidRating(funValue) || !Validator.IsValidRating(copValue) ||
                !Validator.IsValidRating(srsValue) || !Validator.IsValidRating(comValue) ||
                !Validator.IsValidRating(dedValue))
            {
                throw new ArgumentException("Invalid rating value. Ratings must be between 1 and 5.");
            }

            return profiledata.SaveProfile(userId, username, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);
        }

        public int RetrieveUserId(string username)
        {
            return accountdata.RetrieveUserId(username);
        }

        public ProfileInfo RetrieveProfile(int userId)
        {
            return profiledata.RetrieveProfile(userId);
        }

        public List<string> RetrieveGames()
        {
            return gamedata.RetrieveGames();
        }

        public bool SaveUserGames(int userId, List<string> selectedGames)
        {
            return gamedata.SaveUserGames(userId, selectedGames);
        }

        public List<ProfileInfo> GetAllProfiles()
        {
            return profiledata.GetAllProfiles();
        }

        public string GetServiceDetails()
        {
            return "Service Details";
        }

        public List<string> GetUserGames(int userId)
        {
            return gamedata.GetUserGames(userId);
        }

        public bool DeleteProfile(int userId)
        {
            return profiledata.DeleteProfile(userId);
        }
    }
}
