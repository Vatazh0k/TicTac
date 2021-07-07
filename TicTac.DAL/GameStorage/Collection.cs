using System.Collections.Generic;
using System.Threading;
using TicTac.Domain.Model;

namespace TicTac.DAL.GameStorage
{
    public class Collection
    {
        private static Collection _collection;
        private static object _locekr = new object();

        public Dictionary<int, Game> Games { get; set; } = new();

        private Collection() { }
        public static Collection Get()
        {
            lock (_locekr)
            {
                return _collection ??= _collection = new Collection();
            }
        }
    }
}
