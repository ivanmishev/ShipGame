using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    class Logger
    {
        private static List<string> messages = new List<string>();
        private static int startingLine = 0;
        private static int LOG_LENGTH = 5;

        public static void Write(string message)
        {
            messages.Add(message);
            if(startingLine == 0)
            {
                startingLine = Console.CursorTop;
            }
            if (Console.CursorTop == startingLine + LOG_LENGTH)
            {
                CleaLog();
            }
            Console.WriteLine(message);
        }

        private static void CleaLog()
        {
            for (int i = 0; i < LOG_LENGTH; i++)
            {
                Console.SetCursorPosition(0, startingLine + i);
                Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
                Console.SetCursorPosition(0, startingLine);
            }
        }

        public static void SaveToFile()
        {
            string path = "GameLog_" + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss") + ".txt";
            File.WriteAllLines(path, messages.ToArray());
        }
    }
}
