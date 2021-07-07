using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac.Interfaces.Services
{
    public interface IGameConnection
    {
        string CreateGame();
        void JoinGame(string GameId);
    }
}
