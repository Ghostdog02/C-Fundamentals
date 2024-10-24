using System;

namespace AdvertisingMessage
{
    class Message
    {

        public void PraiseworthyPhrase(string[] phrase)
        {
            string result = string.Empty;
            Random rand = new Random();
            for (int i = 0; i < 2; i++)
            {
                int randomPosition = rand.Next(phrase.Length);
                result = phrase[randomPosition];
            }
            Console.Write($"{result}");

        }

        public void PraiseworthyHappening(string[] happening)
        {
            string result = string.Empty;
            Random rand = new Random();
            for (int i = 1; i <= 2; i++)
            {
                int randomPosition = rand.Next(happening.Length);
                result = happening[randomPosition];
            }
            Console.WriteLine($"{result}");

        }

        public void PrintAuthorFirstName(string[] authorFirstName)
        {
            string result = string.Empty;
            Random rand = new Random();
            for (int i = 1; i <= 2; i++)
            {
                int randomPosition = rand.Next(authorFirstName.Length);
                result = authorFirstName[randomPosition];
            }
            Console.Write($" -- {result} ");

        }

        public void PrintAuthorSecondName(string[] authorSecondName)
        {
            string result = string.Empty;
            Random rand = new Random();
            for (int i = 1; i <= 2; i++)
            {
                int randomPosition = rand.Next(authorSecondName.Length);
                result = authorSecondName[randomPosition];
            }
            Console.Write($"{result}, ");

        }

        public void PrintCities(string[] cities)
        {
            string result = string.Empty;
            Random rand = new Random();
            for (int i = 1; i <= 2; i++)
            {
                int randomPosition = rand.Next(cities.Length);
                result = cities[randomPosition];
            }
            Console.WriteLine($"{result}");

        }

        public static void Main()
        {
            string[] phrase = { "The product is excellent.",
                "This is great product.",
                "I use this product all the time.",
                "This is the best product in this category." };
            string[] happening = { "I feel good now.",
                "I managed to change",
                "He did a miracle.",
                "I can't believe it, but I already feel great" };
            string[] authorFirstName = { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya" };
            string[] authorSecondName = { "Ivanova",
                "Petrova",
                "Kirova" };
            string[] cities = { "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse",
                "Burgas"};
            Message mymessage = new Message();
            mymessage.PraiseworthyPhrase(phrase);
            mymessage.PraiseworthyHappening(happening);
            mymessage.PrintAuthorFirstName(authorFirstName);
            mymessage.PrintAuthorSecondName(authorSecondName);
            mymessage.PrintCities(cities);


        }
    }
}

