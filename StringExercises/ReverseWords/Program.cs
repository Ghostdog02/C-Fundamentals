using System;
using System.Text;

namespace ReverseWords
{
    public class Program
    {
        static void Main()
        {
            var text = "C# is not, C++ and PHP, is not Delphi.";
            //var seperator = new char[] { ' ', }
            var words = text.Split(" ");
            StringBuilder reversedText = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedText.Append($"{words[i]} ");
            }
            Console.WriteLine(reversedText.ToString().TrimEnd());
        }

    }
}
