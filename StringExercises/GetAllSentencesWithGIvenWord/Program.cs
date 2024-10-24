using System;
using System.Text.RegularExpressions;

namespace GetAllSentencesWithGivenWord
{
    public class Program
    {
        static void Main()
        {
            string text = @"We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the 
day. We will move out of it in 5 days.";
            string word = "in";
            string[] sentences = text.Split(".", StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, "\\W(in)\\W"))
                {
                    Console.WriteLine($"{sentence}.".TrimStart());
                }
                
            }
        }
    }
}
