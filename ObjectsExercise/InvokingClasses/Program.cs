using Chapter11;
using System;

namespace Examples
{
    class Examples
    {
        static void Main()
        {

            Cat someCat = new Cat();
            someCat.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}.",
            someCat.Name, someCat.Color);
            var mySequence = new Sequence();
            Console.WriteLine("Sequence[1..3]: {0}, {1}, {2}",
            Sequence.NextValue(), Sequence.NextValue(),
Sequence.NextValue());

        }

    }
}
