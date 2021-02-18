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
            string input = Console.ReadLine();

            string pattern = @">>(?<furniture>\w+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            double totalPrice = 0;
            List<string> furnitures = new List<string>();

            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);


                if (match.Success)
                {
                    furnitures.Add(match.Groups["furniture"].Value);
                    totalPrice += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (furnitures.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
