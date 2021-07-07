using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTac.DAL.GameStorage;
using TicTac.Domain.Model;

namespace Application
{
    public static class Field
    {
        public static bool CanPut(Game game, string _x, string _y)
        {
            int x = Convert.ToInt32(_x);
            int y = Convert.ToInt32(_y);

            if (string.IsNullOrEmpty(game.Field[y, x]))
                
            return true; return false; 
        }

        public static bool IsGameEnded(Game game)
        {
            for (int i = 0; i < game.Field.GetLength(0); i++)
            {
                for (int j = 0; j < game.Field.GetLength(1); j++)
                {
                    if (string.IsNullOrEmpty(game.Field[i, j])) return false;
                }
            }

            game.IsFirstUserWin = game.IsFirstUserMove;

            return true;
        }
    }
}
