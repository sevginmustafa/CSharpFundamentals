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
            string descrypt = @"[starSTAR]";
            string pattern = @"@(?<planet>[A-Za-z]+)([^@\-!:>])*:(?<population>\d+)([^@\-!:>])*!(?<attackType>[A|D])!([^@\-!:>])*->(?<soldiersCount>\d+)";

            List<string> A = new List<string>();
            List<string> D = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = "";

                string message = Console.ReadLine();

                MatchCollection counter = Regex.Matches(message, descrypt);
                int count = counter.Count;

                for (int j = 0; j < message.Length; j++)
                {
                    int character = message[j] - count;
                    result += (char)character;
                }

                Match match = Regex.Match(result, pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        A.Add(planetName);
                    }
                    else
                    {
                        D.Add(planetName);
                    }
                }
            }

            A.Sort();
            D.Sort();

            Console.WriteLine($"Attacked planets: {A.Count}");
            if (A.Count > 0)
            {
                foreach (var planet in A)
                {
                    Console.WriteLine("-> " + planet);
                }
            }

            Console.WriteLine($"Destroyed planets: {D.Count}");
            if (D.Count > 0)
            {
                foreach (var planet in D)
                {
                    Console.WriteLine("-> " + planet);
                }
            }
        }
    }
}

