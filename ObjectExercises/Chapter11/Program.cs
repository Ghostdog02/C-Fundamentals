using System;

namespace Chapter11
{
    public class Cat
    {
        // Field name
        private string name;
        // Field color
        private string color;
        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }
        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }
        // Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine($"Cat {name} said: Miauuuuuu!");
        }

    }

    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;
        // Intentionally deny instantiation of this class
        private Sequence()
        {
        }
        // Static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }

    namespace Examples
    {
        class SequenceAndCatManipulating
        {
            static void Main()
            {
                Console.WriteLine("Sequence[1..3]: {0}, {1}, {2}",
                Sequence.NextValue(), Sequence.NextValue(),
                Sequence.NextValue());
                Cat someCat = new Cat();
                someCat.SayMiau();
                Console.WriteLine("The color of cat {0} is {1}.",
                someCat.Name, someCat.Color);
            }
        }
    }
}
