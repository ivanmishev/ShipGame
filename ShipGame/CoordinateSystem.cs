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

        private static readonly char[] X_CORDINATES = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        private static readonly char[] Y_CORDINATES = new char[] { 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P' };

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

        public string[,] getMatrix()
        {

            string[,] test = new string[56,56];
            for (int i = 0; i <= 7; i++)
            {
                char firstX = 'A';
                char nextCharX = (char)((int)firstX + i);
                for (int g = 0; g <= 7; g++)
                {
                    char firstY = 'I';
                    char nextCharY = (char)((int)firstY + g);
                    test[i, g] = "" + nextCharX + nextCharY;
                }
            }
            return test;
        }

        public List<KeyValuePair<char, int>> bindLettersToCursorPosition()
        {
            List<KeyValuePair<char, int>> kvpList = new List<KeyValuePair<char, int>>();

            int tempX = origRow;
            int tempY = origCol;
            //Fill rows
            foreach (char c in Y_CORDINATES)
            {
                kvpList.Add(new KeyValuePair<char, int>(c, tempY));
                tempY += 2;
            }
            //Fill cols
            foreach (char c in X_CORDINATES)
            {
                kvpList.Add(new KeyValuePair<char, int>(c, tempX));
                tempX += 5;
            }
            return kvpList;
        }
    }
}
