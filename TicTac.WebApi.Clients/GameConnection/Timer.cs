using System;
using System.Linq;
using TicTac.DAL.GameStorage;

namespace TicTac.WebApi.Clients.GameConnection
{
    public class Timer
    {
        private static System.Timers.Timer timer;
        private static readonly int AvaibleMinutes = 5;
        public static bool IsActive { get; set; }

        public static void StartTimer()
        {
            IsActive = true;

            timer = new System.Timers.Timer(30000);

            timer.Elapsed += (s, e) => Tick();

            timer.Start();
        }

        public static void StopTimer()
        {
            IsActive = false;

            timer.Elapsed -= (s, e) => Tick();

            timer.Stop();
        }

        private static void Tick()
        {
            var _games = Collection.Get();

            int _keys = default;

            try { _keys = _games.Games.Keys.Max();}

            catch (Exception) { StopTimer();}

            for (var i = _games.Games.Keys
                                       .OrderBy(x => x)    
                                       .FirstOrDefault();
                     i <=  _keys; 
                     i++)
            {
                if (!_games.Games.ContainsKey(i)) 
                    continue;

                if (DateTime.Now - _games.Games[i].StartDate > new TimeSpan(0, AvaibleMinutes, 0))
                    _games.Games.Remove(i);
            }
        }
    }
}
