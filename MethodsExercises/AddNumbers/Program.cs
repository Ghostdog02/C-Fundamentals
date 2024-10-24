using System;
using System.Collections.Generic;

namespace AddNumbers
{
    public class Program
    {
        static void Main()
        {
            int number1 = 16;
            int number2 = 18;
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            string holder1 = number1.ToString();
            string holder2 = number2.ToString();
            for (int i = 0; i < Math.Max(holder1.Length, holder2.Length); i++)
            {
                if (i == holder1.Length)
                {
                    list1.Add(0);
                }

                else if (i == holder2.Length)
                {
                    list2.Add(0);
                }

                else
                {
                    list1.Add(Int32.Parse(holder1[i].ToString()));
                    list2.Add(Int32.Parse(holder2[i].ToString()));
                }

            }
            Console.WriteLine(AddNumbers(list1, list2));
        }

        static int AddNumbers(List<int> list1, List<int> list2)
        {
            var number1 = "";
            var number2 = "";
            foreach (var number in list1)
            {
                number1 += number;
            }

            foreach (var number in list2)
            {
                number2 += number;
            }
            var sum = Int32.Parse(number1) + Int32.Parse(number2);
            return sum;
        }
    }
}
