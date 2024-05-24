using System.Collections.Generic;
using BLL.Models;

namespace BLL
{
    public interface IGTService
    {
        string RetrievePass(string username);
        bool CreateAccount(string email, string hashedPassword, string username);
        bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue);
        int RetrieveUserId(string username);
        ProfileInfo RetrieveProfile(int userId);
        List<ProfileInfo> GetAllProfiles();
        List<string> RetrieveGames();
        bool SaveUserGames(int userId, List<string> selectedGames);
        string GetServiceDetails();
        List<string> GetUserGames(int userId);
    }
}
