using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Program
{
    public class InsertRowNumber
    {
        static void Main()
        {
            var fileName1 = "Example.txt";
            var fileName2 = "Temporary.txt";
            var fs = File.Create(fileName2);
            fs.Dispose();
            InsertRowsInFile2(fileName1, fileName2);
            InsertRowsInFile1(fileName1, fileName2);
        }

        static void InsertRowsInFile2(string fileName1, string fileName2)
        {
            var reader = new StreamReader(fileName1);
            var writer = new StreamWriter(fileName2);
            string? line;
            var counter = 1;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine($"{counter}: " + line);
                counter++;
            }

            reader.Dispose();
            writer.Dispose();
        }

        static void InsertRowsInFile1(string fileName1, string fileName2)
        {
            File.Create(fileName1).Dispose();
            var reader = new StreamReader(fileName2);
            var writer = new StreamWriter(fileName1);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
            reader.Dispose(); 
            writer.Dispose();
            File.Delete(fileName2);
        }
    }
}