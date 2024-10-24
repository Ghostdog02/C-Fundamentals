using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractAllEmailAddressesFromString
{
    public class Program
    {
        static void Main()
        {
            var text = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
            var list = GetEmails(text);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        static List<string> GetEmails(string text)
        {
            Regex regex = new(Regex.Escape("\b[\\w\\.-]+@[\\w\\.-]+\\.\\w{2,4}\b"));
            var matchCollection = regex.Matches(text);
            List<string> matches = new List<string>();
            foreach (var match in matchCollection)
            {
                matches.Add(match.ToString());
            }
            return matches;
        }
    }
}
