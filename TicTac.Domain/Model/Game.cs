using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac.Domain.Model
{
    public class Game
    {
        public String[,] Field { get; set; } = new string[3,3];
        public DateTime StartDate { get; set; } = DateTime.Now;
        public Boolean IsFirstUserMove { get; set; } = true;
        public Boolean? IsFirstUserWin { get; set; } = null;
        public Boolean IsFirstUserReadyToStart { get; set; } = default;
        public Boolean IsSecondUserReadyToStart { get; set; } = default;
        public Boolean IsGameover { get; set; } = default;
        public Boolean DidEnemyConnect { get; set; } = default;


    }
}
