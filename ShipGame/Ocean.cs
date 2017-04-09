using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    class Ocean
    {
        private static readonly char[] X_CORDINATES = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        private static readonly char[] Y_CORDINATES = new char[] {'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P'};
        private const char OCEAN_WAVE = '~';

        public void drawCordinates()
        {
            Console.Write("  ");
            //Console.BackgroundColor = ConsoleColor.White;
            foreach (char x in X_CORDINATES)

            {
                Console.Write("   " + x + " ");
            }
            Console.WriteLine();

            foreach (char y in Y_CORDINATES)
            {
                //Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.Write(y);
                Console.Write(" ");
                //Console.BackgroundColor = ConsoleColor.Blue;
                foreach (char x in X_CORDINATES)
                {
                    //Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("   " + OCEAN_WAVE + " ");
                }
                //Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }

    }
}
