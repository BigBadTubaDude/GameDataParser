using GameDataParser.Interfaces;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GameDataParser.Classes
{
    internal class FileLogger : ILogger
    {
        public FileLogger(string filePath)
        {
            FilePath = filePath;
        }
        public void LogError(Exception error)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine(error.ToString());
            }

        }
        public string FilePath { get; private set; }

    }
}
