using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ParseDictionary
{
    public class Program
    {
        static readonly string givenDictionary = @"NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";
        static void Main()
        {
            SearchWord();
        }

        static void SearchWord()
        {
            var dictionary = CreateDictionary();
            while (true)
            {
                Console.WriteLine($"Enter word from dictionary");
                var input = Console.ReadLine();

                if (dictionary.ContainsKey(input))
                    Console.WriteLine(dictionary[input]);
                else
                    Console.WriteLine($"The word wasn't found in the dictionary");

                Console.WriteLine($"Do you want to stop searching for definitions");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                    break;
            }
        }

        static Dictionary<string, string> CreateDictionary()
        {
            Regex regexWords = new Regex("(?<=^).*?(?=[ -])", RegexOptions.Multiline);
            Regex regexDefinitions = new Regex("(?<=\\W\\s).*?(?=$)", RegexOptions.Multiline);
            var dictionary = new Dictionary<string, string>();
            var words = regexWords.Matches(givenDictionary);
            var definitions = regexDefinitions.Matches(givenDictionary);
            for (int i = 0; i < words.Count; i++)
            {
                dictionary.Add(words[i].ToString(), definitions[i].ToString());
            }
            return dictionary;
        }
    }
}
