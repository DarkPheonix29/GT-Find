using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class GTService
    {
        private readonly IGTData data;
        public GTService(IGTData data)
        {
            this.data = data;
        }

        public string RetrievePass(string username)
        {
            var result = data.RetrievePass(username);
            return result;
        }

        public bool CreateAccount(string email, string hashedPassword, string username)
        {
            var results = data.CreateAccount(email, hashedPassword, username);
            return results;
        }

        public bool SaveProfile(int userId, string bio, string region, string country, string platform, int funValue, int copValue, int srsValue, int comValue, int dedValue)
        {
            var results = data.SaveProfile(userId, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);
            return results;
        }
    }
}
