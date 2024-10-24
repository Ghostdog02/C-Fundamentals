using System;

namespace PythagoreanTheorem
{
    class Program
    {
        public double A { get; set; }

        public double B { get; set; }

        public double CalculateThirdSide()
        {
            return Math.Sqrt((B * B) + (A * A));
        }

        static class TrieangleCalculator
        {
            public static double CalculateThirdSide(double a, double b)
            {
                return Math.Sqrt((b * b) + (a * a));
            }
             
        }


        static void Main()
        {
            Program thirdSide = new Program();
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            double result = TrieangleCalculator.CalculateThirdSide(a, b);

            Console.WriteLine(result);
        }
    }
}
