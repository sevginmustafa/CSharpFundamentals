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

            MatchCollection matches = Regex.Matches(input, @"\+359( |-)2\1\d{3}\1\d{4}\b");

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

