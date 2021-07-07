using TicTac.Interfaces.Services;
using TicTac.Infrastructure.Extentions;
using TicTac.Domain.Model;
using System;
using TicTac.DAL.GameStorage;

namespace TicTac.WebApi.Clients.GameConnection
{
    public class Connect : IGameConnection
    {
        public string CreateGame()
        {
            var _games = Collection.Get();

            try
            {
                var _key = _games.Games.GetEmptyKey();

                _games.Games.Add(_key, new Game());

                if (Timer.IsActive is not true) Timer.StartTimer();

                return _key.ToString();
            }
            catch (Exception)
            {
                throw new Exception("No free game :(");
            }
        }

        public void JoinGame(string _gameId)
        {
            var _games = Collection.Get();

            bool _isValid = int.TryParse(_gameId, out var _id);

            if (_isValid is false) throw new Exception("Inncorrect number!");

            _isValid = _games.Games.ContainsKey(_id);

            if(_isValid is false) throw new Exception("Inncorrect game Id!");

            _isValid = !_games.Games[_id].DidEnemyConnect;

            if(_isValid is false) throw new Exception("This game already played");

            _games.Games[_id].DidEnemyConnect = true;
        }
    }
}
