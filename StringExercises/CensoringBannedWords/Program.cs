using System;
using System.Text.RegularExpressions;

namespace CensoringBannedWords
{
    public class Program
    {
        static void Main()
        {
            var text = @"Microsoft announced its next generation C# compiler today. It
uses advanced parser and special optimizer for the Microsoft CLR.";
            var bannedWords = "C#,CLR,Microsoft";
            var wordsSplit = bannedWords.Split(',');
            foreach (var word in wordsSplit)
            {
                Regex regex = new Regex(word);
                text = regex.Replace(text, delegate (Match m)
                {
                    return new string('*', word.Length);
                });
            }
            Console.WriteLine(text);
        }
    }
}
