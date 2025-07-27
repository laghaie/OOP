using Library;

namespace OOP.Domain.Enities
{
    //SOLID
    public class Log
    {
        public void LogConsole(string msg)
        {
            Utils.Print(msg, Library.Enums.PrintState.Warning);
        }

        public void LogFile(string msg, string path)
        {
            File.WriteAllText(path, msg);
        }

        public void LogDb(string msg, string connectionString)
        {

        }
    }
}
