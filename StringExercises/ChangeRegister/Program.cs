using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChangeRegister
{
    public class Program
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder();
            //Regex regex = new Regex("/<upcase>]\\w*/g");
            Regex regex = new Regex("(<upcase>\\w*)|(\\w*</upcase>)");
            var text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            var matches = regex.Matches(text);
            foreach (var match in matches)
            {
                text = text.Replace(match.ToString(), match.ToString().ToUpper());
            }

            text = text.Replace("<upcase>".ToUpper(), "");
            text = text.Replace("</upcase>".ToUpper(), "");
            Console.WriteLine(text);




        }
    }
}
