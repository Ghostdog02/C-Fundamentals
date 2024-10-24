using System;

namespace ShuntingYardAlgorithm
{
    class Program
    {

       public static void Main()
        {
            string tokens = "1+(21-1)";
            int number = 1;
            while (tokens != string.Empty)
            {
                tokens = Console.ReadLine();
                if (int.TryParse(tokens, out number))
                {
                    
                }
            }


        }
    }
}
