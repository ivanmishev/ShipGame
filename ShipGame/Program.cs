using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


            Logger.Write(sh1.ShipName + " " + sh1.ShipPosition[0]);
            Logger.Write(sh2.ShipName + " " + sh2.ShipPosition[0]);
            Logger.Write(hs1.ShipName + " " + hs1.ShipPosition[0]);

            CoordinateSystem coordSys = new CoordinateSystem(0, 0);
            CoordinateSystem.WriteAt("O", 5, 3);
            Console.SetCursorPosition(0,40);

            Logger.Write(Console.CursorLeft +"  " +  Console.CursorTop);
            //Console.WriteLine("Press ESC to stop");
            do
            {
                //while (!Console.KeyAvailable)
                {
                    Logger.Write(Console.ReadKey(true).Key.ToString());
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Logger.SaveToFile();
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
