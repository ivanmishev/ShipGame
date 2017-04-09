using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    class Program
    {
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Blue;

        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            SetBackgroundColor();
            Ocean ocean = new Ocean();
            ocean.drawCordinates();

            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            //WriteAt("OOO", 2, 2);

            string[] cords = { "AD","FG" } ;
            Ships sh1 = new Ships(ShipType.small, cords);
            Ships sh2 = new Ships(ShipType.small, cords);

            Ships hs1 = new Ships(ShipType.huge, cords);


            Console.WriteLine(sh1.ShipName + " ");
            Console.WriteLine(sh2.ShipName + " ");
            Console.WriteLine(hs1.ShipName + " " + hs1.ShipPosition[0]);


        }

        /// <summary>
        /// Paint a background color
        /// </summary>
        /// <remarks>
        /// It is very important that you run the Clear() method after
        /// changing the background color since this causes a repaint of the background
        /// </remarks>
        static void SetBackgroundColor()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear(); //Important!
        }
    }
}
