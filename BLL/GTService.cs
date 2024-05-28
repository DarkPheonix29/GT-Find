using BLL.IGTData;
using BLL.Models; 
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
            if (string.IsNullOrEmpty(country)) { throw new ArgumentNullException("country can not be null"); }

            var results = profiledata.SaveProfile(userId, username, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);
            return results;
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

        public string GetServiceDetails()
        {
            return "Service Details";
        }
        public List<string> GetUserGames(int userId)
        {
            var results = gamedata.GetUserGames(userId);
            return results;
        }
        public bool DeleteProfile(int userId)
        {
            var results = profiledata.DeleteProfile(userId);
            return results;
        }
    }
}
