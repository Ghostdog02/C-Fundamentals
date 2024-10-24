using System;
using System.Text.RegularExpressions;

namespace ReplaceHTMLHyperlinksWithReferences
{
    public class Program
    {
       

        static void Main()
        {
             string text = "<p>Please visit <a href=\"http://softuni.bg\">our site</a> to choose a software engineering training course." +
           " Also visit<a href=\"http://softuni.bg\"/forum\">our forum</a> to discuss the courses.</p>";
            ReplaceHyperlinks(text);
        }

        static void ReplaceHyperlinks(string text)
        {
            var newText = text;
            //Regex regex = new Regex("<a\\shref=\"(\\w.*)\">");
            Regex regex = new Regex(@"<a\Whref=""(\w.*"")>");
            //<a\Whref=""(\w.*"")>
            //<a\\Whref=\"(\\w.*)\">
            var replacement = "[URL=$1]";
            var matches = regex.Matches(text);
            foreach (var match in matches)
            {
                newText = regex.Replace(newText, replacement);
            }
            Regex regex1 = new Regex("(<a)|(</a>)");
            regex1.Replace(text, "");
            Console.WriteLine(newText);
        }
    }
}
