using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IGTData
{
    public interface IGTProfileData
    {
        bool SaveProfile(int userId, string username, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue);

        ProfileInfo RetrieveProfile(int userId);

        List<ProfileInfo> GetAllProfiles();

        bool DeleteProfile(int userId);
    }
}
