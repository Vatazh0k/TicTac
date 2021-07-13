using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTac.DAL.GameStorage;
using TicTac.Domain.Model;
using TicTac.Infrastructure.Extentions;

namespace Application
{
    public static class Field
    {
        public static bool CanPut(Game game, int _x, int _y)
        {//asign mark. Field will be null always...
            if (string.IsNullOrEmpty(game.Field[_y, _x]))//
                
            return true; return false; 
        }

        public static bool IsGameEndedWithoutWinner(Game game) => !game.Field.HasEmptyCell();

        public static bool IsGameEndedWithWinner(Game game) => game.Field.HasWinner();
    }
}
