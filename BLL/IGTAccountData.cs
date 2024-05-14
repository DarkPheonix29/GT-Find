using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGTAccountData
    {
        string RetrievePass(string username);

        bool CreateAccount(string email, string hashedPassword, string username);

        public int RetrieveUserId(string username);

    }
}
