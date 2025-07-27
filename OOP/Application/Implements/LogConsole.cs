using Library;
using OOP.Domain.Interfaces;

namespace OOP.Application.Implements
{
    public class LogConsole : ILogger
    {
        public void Log(string message)
        {
            Utils.Print(message, Library.Enums.PrintState.Warning);
        }
    }
}
