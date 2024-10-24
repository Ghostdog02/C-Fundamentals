using System;
using Chapter11;

namespace Create10Objects
{
    public class Program
    {
        static void Main()
        {
            for (int n = 0; n < 10; n++)
            {
                Cat cat = new Cat();
                cat.Name = $"cat{n}";
            }
        }
    }
}
