using System;

namespace Functions.Lib
{
    public class DisplayMessages
    {
        public static void ShowMessage(string msg, bool isError = false)
        {
            if (!isError)
            {
                DisplayInfo(msg);
            }
            else
            {
                DisplayError(msg);
            }
        }

        private static void DisplayError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        private static void DisplayInfo(string info)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(info);
            Console.ResetColor();
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static void ShowTime(string format)
        {
            Console.WriteLine(DateTime.Now.ToString(format));
        }
    }
}
