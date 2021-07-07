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
        public static bool CanPut(Game game, int _x, int _y)
        {//asign mark. Field will be null always...
            if (string.IsNullOrEmpty(game.Field[_y, _x]))//
                
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
