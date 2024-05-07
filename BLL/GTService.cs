using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
