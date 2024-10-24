using System;
using System.Collections.Generic;

namespace MultiplyPolynoms
{
    public class Program
    {
        static void Main()
        {
            int[] coeficientsPolynom1 = { -3, 1, 3 };
            int[] coeficientsPolynom2 = { -1, 1, 0 };
            Console.WriteLine(Multiply(coeficientsPolynom1, coeficientsPolynom2));
        }

        static string Multiply(int[] coeficientsPolynom1, int[] coeficientsPolynom2)
        {
            int multiplication = 0;
            int power = 0;
            List<int> listOfPolynoms = new List<int>();
            int[] arrayOfPolynoms = new int[coeficientsPolynom1[coeficientsPolynom1.Length - 1] + coeficientsPolynom2[coeficientsPolynom2.Length - 1] + 1];
            for (int i = 0; i < coeficientsPolynom1.Length; i++)
            {
                for (int j = 0; j < coeficientsPolynom2.Length; j++)
                {
                    if (coeficientsPolynom1[i] != 0 && coeficientsPolynom2[j] != 0)
                    {
                        multiplication = coeficientsPolynom1[i] * coeficientsPolynom2[j];
                        if (multiplication != 0)
                        {
                            power = i + j;
                            if (arrayOfPolynoms[power] != 0 && (i != 0 || j != 0))
                                arrayOfPolynoms[power] += multiplication;
                            else
                                arrayOfPolynoms[power] = multiplication;
                        }

                    }
                }


            }
            listOfPolynoms.AddRange(arrayOfPolynoms);
            return NormalizePolynom(listOfPolynoms);


        }

        static string NormalizePolynom(List<int> listOfPolynoms)
        {
            var polynomMultiplied = "";
            var listOfPolynomsReversed = new List<string>();
            var currentIndex = 0;
            foreach (var polynom in listOfPolynoms)
            {
                currentIndex++;
                var currentElement = polynom;

                if (currentIndex == 0)
                {
                    listOfPolynomsReversed.Add(currentElement < 0 ? $"{currentElement} + " : $"{currentElement} + ");
                }

                else if (currentIndex == 1)
                {
                    if (currentElement < 0)
                        listOfPolynomsReversed.Add($"{currentElement} * x ");
                    else
                        listOfPolynomsReversed.Add(currentElement > 1 ? $" + {currentElement} * x " : $" + x ");
                }

                else
                {
                    listOfPolynomsReversed.Add(currentElement == 0 ? $" + x ^ {currentIndex}" : $" {currentElement} * x ^ {currentIndex} ");

                }
            }

            listOfPolynomsReversed.Reverse();
            foreach (var x in listOfPolynomsReversed)
            {
                polynomMultiplied += x;
            }

            return polynomMultiplied;
        }
    }
}
