using System;
using System.Text;
using System.Text.Unicode;
namespace ConvertStringToUnicodeSeries
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            foreach (ushort letter in input)
            {
                ushort number = Convert.ToUInt16(letter);
                Console.Write("\\u{0:x4}", number);
            }


        }
    }
}
