using System;
using System.Collections.Generic;

namespace AddTwoPolynomials
{
    public class Program
    {
        static void Main()
        {
            int[] coeficientsPolynom1 = { -3, 1, 3 };
            int[] coeficientsPolynom2 = { -1, 1, 0 };
            Console.WriteLine(CalculateSum(coeficientsPolynom1, coeficientsPolynom2));
        }

        static string CalculateSum(int[] coeficientsPolynom1, int[] coeficientsPolynom2)
        {
            int sum = 0;
            var polynom = "";
            List<string> listOfPolynoms = new List<string>();
            for (int i = 0; i < coeficientsPolynom1.Length; i++)
            {
                sum = coeficientsPolynom1[i] + coeficientsPolynom2[i];
                if (i == 0)
                {
                    listOfPolynoms.Add(sum < 0 ? $"{sum}" : $" + {sum}");
                }

                else if (i == 1)
                {

                    listOfPolynoms.Add(sum > 1 ? $" + {sum} * x " : $" + x ");

                }

                else
                {
                    listOfPolynoms.Add(sum == 0 ? $"+ x ^ {i}" : $"{sum} * x ^ {i}");

                }

            }
                       
            listOfPolynoms.Reverse();
            foreach (var x in listOfPolynoms)
            {
                polynom += x;
            }
            return polynom;
        }
    }
}
