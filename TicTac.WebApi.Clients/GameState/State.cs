using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTac.DAL.GameStorage;
using TicTac.Domain.Model;
using TicTac.Interfaces.Services;

namespace TicTac.WebApi.Clients.GameState
{
    public class State : IState
    {
        public Game GetGameState(string gameId)
        {
            var _games = Collection.Get();

            bool _isValid = int.TryParse(gameId, out var id);

            if (_isValid is false) throw new Exception("Incorrect number");

            _isValid = _games.Games.ContainsKey(id);

            if (_isValid is false) throw new Exception("This game is not exist");

            return _games.Games[id];
        }
    }
}
