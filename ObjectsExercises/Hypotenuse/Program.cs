using System;

namespace Triangle
{
    public class Triangle
    {
        public int A { get; set; }

        public int B { get; set; }

        public double C { get; set; }

        public double CalculatingHypotenuse()
        {
            C = Math.Sqrt(A * A + B * B);
            return C;
        }

    }
    public class Program
    {
        public static void Main()
        {
            Triangle triangle = new Triangle();
            Console.WriteLine($"Enter a: ");
            triangle.A = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter b: ");
            triangle.B = int.Parse(Console.ReadLine());
            double hypotenuse = triangle.CalculatingHypotenuse();
            hypotenuse = Math.Round(hypotenuse, 2);
            Console.WriteLine($"The hypotenuse is {hypotenuse} cm");

        }
    }
}
