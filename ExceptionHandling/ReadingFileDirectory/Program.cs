using System;
using System.IO;

namespace ReadingFileDirectory
{
    public class Program
    {
        static void Main()
        {

            try
            {
                Console.WriteLine($"Enter File Name");
                string fileName = Console.ReadLine();
                ReadFile(fileName);
            }

            catch (Exception e)
            {
                Console.WriteLine($"The file could not be read");
                Console.WriteLine(e.Message);
            }
        }

        static void ReadFile(string fileName)
        {
            string text = "";
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"The file doesn't exist");
                return;
            }

            //using StreamReader reader = new StreamReader(fileName);
            //while (reader.ReadLine() != null)
            //{
            //    text += reader.ReadLine();
            //}
            //return text;
            text = File.ReadAllText(fileName);
            Console.WriteLine(text);

        }
    }
}
