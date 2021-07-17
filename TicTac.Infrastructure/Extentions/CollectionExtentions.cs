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
            var key = game.Keys.Count > 0 
                    ? game.Keys.Max() 
                    : game.Keys.FirstOrDefault() + 1;

            for (int current = 1; current <= key; current++) if (!game.ContainsKey(current))
                    
            return current; return key + 1;

        }
    }
}

