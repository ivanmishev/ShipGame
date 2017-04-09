using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace ShipGame
{
    class CoordinateSystem
    {
        const ConsoleColor CURSOR_COLOR = ConsoleColor.DarkBlue;

        private static int origRow;
        private static int origCol;

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        public static void WriteAt(string s, int x, int y)
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

        public CoordinateSystem(int origCol, int origRow)
        {
            CoordinateSystem.origRow = origRow;
            CoordinateSystem.origCol = origCol;
        }
    }
}
