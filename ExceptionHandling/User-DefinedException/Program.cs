using System;
using System.IO;
using System.Linq;

namespace User_DefinedException
{
    public class Program
    {
        static void Main()
        {
            string fileName = "D:\\Documents\\nok1.txt";
            int count = 0;
            using StreamReader reader = new StreamReader(fileName);
            while (!reader.EndOfStream)
            {
                count++;
                var line = reader.ReadLine();
                if (!line.All(char.IsDigit))
                {
                    throw new FileParseException(fileName, count);
                }

            }
        }
    }

    public class FileParseException : Exception
    {
        public FileParseException() { }

        public FileParseException(string fileName, int lineNumber)
            : base($"Invalid number in file {fileName} in line {lineNumber}") { }

    }
}
