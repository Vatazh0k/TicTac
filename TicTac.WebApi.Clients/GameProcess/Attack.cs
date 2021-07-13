using Application;
using System;
using TicTac.DAL.GameStorage;
using TicTac.Infrastructure.Extentions;
using TicTac.Interfaces.Services;

namespace TicTac.WebApi.Clients.GameProces
{
    public class Attack : IAttack
    {
        public void PutSign(string id, string x, string y)
        {
            var _games = Collection.Get();

            bool _isValid = int.TryParse(id, out var gameId);

            if (_isValid is false) throw new Exception("Incorrect number");

            _isValid = _games.Games.ContainsKey(gameId);

            if (_isValid is false) throw new Exception("This game is not exist");

            if (_games.Games[gameId].IsGameover is true) return;

            _isValid = Field.CanPut(_games.Games[gameId], x.ToInt32(), y.ToInt32());

            if (_isValid is false) throw new Exception("You cant to put mark here!");

            _games.Games[gameId].IsGameover = Field.IsGameEndedWithWinner(_games.Games[gameId]);

            if (_games.Games[gameId].IsGameover is true)
            {
                _games.Games[gameId].IsFirstUserWin = _games.Games[gameId].IsFirstUserMove;

                return;
            }

            _games.Games[gameId].IsGameover = Field.IsGameEndedWithoutWinner(_games.Games[gameId]);

            if (_games.Games[gameId].IsGameover is true)
            {
                _games.Games.Remove(gameId);

                throw new Exception("No winner :(");
            }

            _games.Games[gameId].IsFirstUserMove = !_games.Games[gameId].IsFirstUserMove;

        }
    }
}
