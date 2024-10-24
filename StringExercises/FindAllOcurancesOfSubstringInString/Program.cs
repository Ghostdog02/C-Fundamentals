using System;

namespace FindAllOcurancesOfSubstringInString
{
    public class Program
    {
        static void Main()
        {
            var text = @"We are living in a yellow submarine. We don't have anything else.
Inside the submarine is very tight. So we are drinking all the
day. We will move out of it in 5 days.";
            var count = 1;
            var keyword = "in";
            var index = text.IndexOf(keyword);
            text = text.ToLower();
            
            while (index != -1)
            {
                index = text.IndexOf(keyword, index + keyword.Length);
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
