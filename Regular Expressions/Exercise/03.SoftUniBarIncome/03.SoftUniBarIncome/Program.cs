using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            string input = Console.ReadLine();

            double total = 0;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double totalPrice = int.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    total += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}

