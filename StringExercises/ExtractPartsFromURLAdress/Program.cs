using System;
using System.Text.RegularExpressions;

namespace ExtractPartsFromURLAdress
{
    public class Program
    {
        static void Main()
        {
            //example: [protocol]://[server]/[resource]
            var urlAddress = "http://www.devbg.org/forum/index.php";
            //matches string between to characters
            Regex regex = new Regex("(?<=^).*?(?=:)");
            var protocol = regex.Match(urlAddress);
            Console.WriteLine($"[protocol] = {protocol}");
            //matches string between to characters
            Regex regex1 = new Regex("(?<=//).*?(?=/)");
            var server = regex1.Match(urlAddress);
            Console.WriteLine($"[server] = {server}");
            //matches string between to characters
            Regex regex2 = new Regex("(?<=\\w)/.*?(?=$)");
            var resource = regex2.Match(urlAddress);
            Console.WriteLine($"[resource] = {resource}");

        }
    }
}
