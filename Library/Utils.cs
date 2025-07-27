using Library.Enums;

namespace Library
{
    public class Utils
    {
        /// <summary>
        /// Print Console
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="PrintPrintState">Color of message</param>
        public static void Print(string msg, PrintState PrintState = PrintState.Information)
        {
            switch (PrintState)
            {
                case PrintState.Information:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case PrintState.Success:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case PrintState.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case PrintState.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }

            Console.WriteLine(msg);
        }
    }
}
