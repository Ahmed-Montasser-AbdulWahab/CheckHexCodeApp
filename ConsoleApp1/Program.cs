using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter E to exit\nOR\nPress another key to Continue");
                var input = Console.ReadKey();
                if(input.Key == ConsoleKey.E)
                {
                    break;
                }
                Console.WriteLine("Enter Hex Code:");
                var hexCode = Console.ReadLine();
                if (hexCode != null)
                {
                    Console.WriteLine($"{hexCode} is {IsHexCode(hexCode)} hex code");
                } else { Console.WriteLine("TRY AGAIN"); }
            }
        }

        public static bool IsHexCode(string code)
        {
            string regex = @"^#[A-Fa-f0-9]{6}$";
            Regex r = new Regex(regex, RegexOptions.IgnoreCase);

            var match = r.Match(code);
            return match.Success;

        }
        
        
        

    }
}
