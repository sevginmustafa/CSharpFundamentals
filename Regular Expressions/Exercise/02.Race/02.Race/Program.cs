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
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            Dictionary<string, int> result = new Dictionary<string, int>();

            string namePattern = @"[A-Za-z]";
            string distancePattern = @"\d";

            while (input != "end of race")
            {
                MatchCollection matchesName = Regex.Matches(input, namePattern);
                MatchCollection matchesDistance = Regex.Matches(input, distancePattern);

                string name = string.Concat(matchesName);
                int distance = matchesDistance.Select(x => int.Parse(x.Value)).Sum();

                if (participants.Contains(name))
                {
                    if (result.ContainsKey(name))
                    {
                        result[name] += distance;
                    }
                    else
                    {
                        result.Add(name, distance);
                    }
                }
                input = Console.ReadLine();
            }

            var sorted = result.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
