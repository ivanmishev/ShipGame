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
            Console.Write("Player board");
            Console.WriteLine();
            ocean.drawCordinates();

            Console.WriteLine();
            Console.Write("Computer board");
            Console.WriteLine();
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

            CoordinateSystem coordSys = new CoordinateSystem();
            CoordinateSystem.WriteAt("O", 10, 7);
            Console.SetCursorPosition(0,40);

            //Console.WriteLine("Press ESC to stop");
            do
            {
                //while (!Console.KeyAvailable)
                {
                    Console.Out.Write(Console.ReadKey(true).Key);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
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
