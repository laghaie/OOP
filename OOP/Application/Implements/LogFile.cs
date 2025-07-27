using OOP.Domain.Interfaces;
using System.IO;

namespace OOP.Application.Implements
{
    public class LogFile : ILogger
    {
        private string _filePath;

        public LogFile(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            File.WriteAllText(_filePath, message);
        }
    }
}
