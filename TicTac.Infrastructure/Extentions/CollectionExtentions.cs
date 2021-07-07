using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTac.Domain.Model;

namespace TicTac.Infrastructure.Extentions
{
    public static class CollectionExtentions
    {
        public static int GetEmptyKey(this Dictionary<int, Game> game)
        {
            try
            {
                for (int i = 1; i <= game.Keys.Max(); i++)
                {
                    if (!game.ContainsKey(i)) return i;
                }

                return game.Keys.Max() + 1;
            }
            catch (Exception)
            {
                return game.Keys.FirstOrDefault() + 1;
            }
        }
    }
}

