﻿using BLL.IGTData;
<<<<<<< Updated upstream
using BLL.Models;
using BLL.Validators;
using System;
=======
using BLL.Models; 
>>>>>>> Stashed changes
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
            var result = accountdata.RetrievePass(username);
            return result;
        }

        public bool CreateAccount(string email, string hashedPassword, string username)
        {
            var results = accountdata.CreateAccount(email, hashedPassword, username);
            return results;
        }

        public bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue)
        {
<<<<<<< Updated upstream
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
=======
            if (string.IsNullOrEmpty(country)) { throw new ArgumentNullException("country can not be null"); }

            var results = profiledata.SaveProfile(userId, username, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);
            return results;
>>>>>>> Stashed changes
        }

        public int RetrieveUserId(string username)
        {
            var results = accountdata.RetrieveUserId(username);
            return results;
        }

        public ProfileInfo RetrieveProfile(int userId)
        {
            var results = profiledata.RetrieveProfile(userId);
            return results;
        }

        public List<string> RetrieveGames()
        {
            var results = gamedata.RetrieveGames();
            return results;
        }

        public bool SaveUserGames(int userId, List<string> selectedGames)
        {
            var results = gamedata.SaveUserGames(userId, selectedGames);
            return results;
        }

        public List<ProfileInfo> GetAllProfiles()
        {
            var results = profiledata.GetAllProfiles();
            return results;
        }

        public bool DeleteProfile(int userId)
        {
            return profiledata.DeleteProfile(userId);
        }
    }
}
