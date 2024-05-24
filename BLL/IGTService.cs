using BLL.IGTData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGTService
    {
        public string RetrievePass(string username);
        public bool CreateAccount(string email, string hashedPassword, string username);
        public bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue);
        public int RetrieveUserId(string username);
        public ProfileInfo RetrieveProfile(int userId);
        public List<string> RetrieveGames();
        public bool SaveUserGames(int userId, List<string> selectedGames);
        public List<ProfileInfo> GetAllProfiles();
        bool DeleteProfile(int userId);
    }
}
