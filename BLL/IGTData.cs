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
    }
}
