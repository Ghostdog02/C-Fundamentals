using System;

namespace CalculateSurface
{
    class Program
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int H { get; set; }
        public int Angle { get; set; }
        public void CalculateHeronFormula()
        {
            //p = halfPerimiter
            double p = (A + B + C) / 2;
            double surface = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine(surface);
        }
        public void CalculateSurface()
        {
            double surface = (A * H) / 2;
            Console.WriteLine(surface);
        }
        public void CalculateSurfaceWithSinus()
        {
            double surface = (A * B * Math.Sin(Angle))/2;
            Console.WriteLine(surface);
        }
        static void Main()
        {
            var surface = new Program();
            Console.Write($"Choose task(Calculate Heron formula, Calculate surface, Calculate surface using sinus): ");
            string task = Console.ReadLine().ToLower();
            if (task == "calculate heron formula")
            {
                surface.A = int.Parse(Console.ReadLine());
                surface.B = int.Parse(Console.ReadLine());
                surface.C = int.Parse(Console.ReadLine());
                surface.CalculateHeronFormula();
            }
            else if (task == "calculate surface")
            {
                surface.A = int.Parse(Console.ReadLine());
                surface.H = int.Parse(Console.ReadLine());
                surface.CalculateSurface();
            }
            else
            {
                surface.A = int.Parse(Console.ReadLine());
                surface.B = int.Parse(Console.ReadLine());
                surface.Angle = int.Parse(Console.ReadLine());
                surface.CalculateSurfaceWithSinus();
            }


        }
    }
}
