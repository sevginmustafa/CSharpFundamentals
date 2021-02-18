using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<name>[A-Za-z]+)([^-@!:>]+)?![G]!";

            int key = int.Parse(Console.ReadLine());

            string input = string.Empty;

            List<string> result = new List<string>();

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)(input[i] - key));
                }

                string toString = sb.ToString();

                if (Regex.IsMatch(toString, pattern))
                {
                    Match match = Regex.Match(toString, pattern);

                    string name = match.Groups["name"].Value;

                    result.Add(name);
                }
            }

            foreach (var child in result)
            {
                Console.WriteLine(child);
            }
        }
    }
}

