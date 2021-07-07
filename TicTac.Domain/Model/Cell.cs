using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac.Domain.Model
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }
}
