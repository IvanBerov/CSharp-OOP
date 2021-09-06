using System.IO;
using System.Linq;

namespace Logger.Loggers
{
    public class LogFile : ILogFile
    {
        private const string FilePath = "../../../log.txt";

        public int Size => File.ReadAllText(FilePath)
            .Where(c => char.IsLetter(c))
            .Sum(s => s);

        public void Write(string content)
        {
            File.AppendAllText(FilePath, content);
        }
    }
}
