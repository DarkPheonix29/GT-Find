using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BLL.IGTData;

namespace BLL
{
    public class GTService
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

        public bool SaveProfile(int userId, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue)
        {
            var results = profiledata.SaveProfile(userId, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);
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
    }
}
