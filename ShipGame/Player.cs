using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    class Player
    {
        private int cursorRow = 0;
        private int cursorCol = 0;
        private CoordinateSystem cs = new CoordinateSystem(3, 5);

        public string test()
        {
            return cs.getMatrix()[0, 2];
        }
    }
}
