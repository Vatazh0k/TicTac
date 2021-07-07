using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTac.Domain.Model;

namespace TicTac.Interfaces.Services
{
    public interface IState
    {
        Game GetGameState(string gameId);
    }
}
