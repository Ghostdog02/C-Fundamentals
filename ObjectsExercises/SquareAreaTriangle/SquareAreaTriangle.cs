using System;

namespace SquareAreaTriangle
{
    public class SquareAreaTriangle
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public int H { get; set; }

        public int Angle { get; set; }

        public double HeronsFormula()
        {
            double halfPerimeter = (A + B + C) / 2;
            double squareArea = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            squareArea = Math.Round(squareArea, 2);
            return squareArea;
        }

        public double HeightFormula()
        {
            double squareArea = (A * H) / 2;
            squareArea = Math.Round(squareArea, 2);
            return squareArea;
        }

        public double SinusFormula()
        {
            double squareArea = (A * B * Math.Sin(Angle)) / 2;
            squareArea = Math.Round(squareArea, 2);
            return squareArea;
        }

    }

    public class Program
    {
        public static void Main()
        {
            SquareAreaTriangle squareArea = new SquareAreaTriangle();
            Console.Write($"Choose formula(herons, height or sinus): ");
            string formula = Console.ReadLine().ToLower();
            if (formula == "herons")
            {
                Console.Write($"Enter a: ");
                squareArea.A = int.Parse(Console.ReadLine());
                Console.Write($"Enter b: ");
                squareArea.B = int.Parse(Console.ReadLine());
                Console.Write($"Enter c: ");
                squareArea.C = int.Parse(Console.ReadLine());
                Console.WriteLine($"The square area of this triangle is {squareArea.HeronsFormula()} cm2");

            }
            else if (formula == "height")
            {
                Console.Write($"Enter a: ");
                squareArea.A = int.Parse(Console.ReadLine());
                Console.Write($"Enter h: ");
                squareArea.H = int.Parse(Console.ReadLine());
                Console.WriteLine($"The square area of this triangle is {squareArea.HeronsFormula()} cm2");

            }
            else
            {
                Console.Write($"Enter a: ");
                squareArea.A = int.Parse(Console.ReadLine());
                Console.Write($"Enter b: ");
                squareArea.B = int.Parse(Console.ReadLine());
                Console.Write($"Enter angle: ");
                squareArea.Angle = int.Parse(Console.ReadLine());
                Console.WriteLine($"The square area of this triangle is {squareArea.SinusFormula()} cm2");
            }
        }
    }
    
}
