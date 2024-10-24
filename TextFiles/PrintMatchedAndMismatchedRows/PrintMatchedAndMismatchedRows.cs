using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class PrintMatchedAndMismatchedRows
    {
        static void Main()
        {
            var fileName1 = "Example1.txt";
            var fileName2 = "Example2.txt";
            CompareTextFiles(fileName1, fileName2);
        }

        static void CompareTextFiles(string fileName1, string fileName2)
        {
           
            using var reader1 = new StreamReader(fileName1);
            using var reder2 = new StreamReader(fileName2);
            string? line1;
            string? line2;
            int matched = 0;
            int missmatched = 0;

            while ((line1 = reader1.ReadLine()) != null)
            {
                if ((line2 = reder2.ReadLine()) == null)
                {
                    throw new ArgumentException($"The {fileName2} has less rows than {fileName1}");
                }

                if (line1.Equals(line2))
                {
                    matched++;
                }

                else
                {
                    missmatched++;
                }
            }

            Console.WriteLine($"The count of matching rows is {matched}");
            Console.WriteLine($"THe count of missmatched rows is {missmatched}");
        }
    }
}

