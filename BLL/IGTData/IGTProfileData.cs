using System.Collections.Generic;
using BLL.Models; 

namespace BLL.IGTData
{
    public interface IGTProfileData
    {
        bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue);
        ProfileInfo RetrieveProfile(int userId); // Ensure correct type is used
        List<ProfileInfo> GetAllProfiles(); // Ensure correct type is used
        public bool DeleteProfile(int userId);
    }
}
