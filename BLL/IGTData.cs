using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGTData
    {
        string RetrievePass(string username);

        bool CreateAccount(string email, string hashedPassword, string username);

        bool SaveProfile(int userId, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue);

        public int RetrieveUserId(string username);

    }
}
