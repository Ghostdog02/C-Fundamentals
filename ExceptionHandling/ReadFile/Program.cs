using System;
using System.IO;

namespace ReadFile
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

        static string ReadFile(string fileName)
        {
            string text = "";
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"The file doesn't exist");
                return "";
            }

            using StreamReader reader = new StreamReader(fileName);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                text += line;
            }

            return text;



        }
    }
}
