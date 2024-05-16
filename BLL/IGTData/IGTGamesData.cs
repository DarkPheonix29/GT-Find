using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IGTData
{
    public interface IGTGamesData
    {
        public List<string> RetrieveGames();

        public bool SaveUserGames(int userId, List<string> selectedGames);
    }
}
