using System;
using System.IO;
using System.Text;

namespace ReadingTextFile
{
    public class Program
    {
        public static void Main()
        {
            Console.Write($"Enter the name of the text file: ");
            string textFileName = Console.ReadLine();
            ReadTextFile(textFileName);
        }

        public static void ReadTextFile(string textFileName)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(textFileName);
                string line = reader.ReadLine();
                StringBuilder lines = new StringBuilder(line);
                while (line != null)
                {

                    Console.WriteLine("Line {0}: ", line);
                    line = reader.ReadLine();
                }


            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {textFileName} not found!");

            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                }

            }
        }
    }
}
