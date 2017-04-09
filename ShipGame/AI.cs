using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    class AI
    {
        private int cursorRow = 0;
        private int cursorCol = 0;
        private CoordinateSystem cs = new CoordinateSystem(22, 5);

        //public string[][] matrix = cs.getMatrix();

        public void test()
        {
            string[,] matrix = cs.getMatrix();
            foreach (string s in matrix)
            {
                Console.Write(s + "");
            }
        }

    }
}
