using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> allConstests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStatistics = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] splittedInput = input.Split(" -> ");

                string username = splittedInput[0];
                string contest = splittedInput[1];
                int points = int.Parse(splittedInput[2]);

                if (!allConstests.ContainsKey(contest))
                {
                    allConstests.Add(contest, new Dictionary<string, int>());
                    allConstests[contest].Add(username, points);
                }

                if (!allConstests[contest].ContainsKey(username))
                {
                    allConstests[contest][username] = points;
                }

                if (points > allConstests[contest][username])
                {
                    allConstests[contest][username] = points;
                }
            }

            foreach (var contest in allConstests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int counter1 = 0;

                foreach (var user in contest.Value.OrderByDescending(points => points.Value).ThenBy(name => name.Key))
                {
                    counter1++;

                    Console.WriteLine($"{counter1}. {user.Key} <::> {user.Value}");
                }
            }

            foreach (var contest in allConstests)
            {
                foreach (var user in contest.Value)
                {
                    if (!individualStatistics.ContainsKey(user.Key))
                    {
                        individualStatistics.Add(user.Key, user.Value);
                    }
                    else
                    {
                        individualStatistics[user.Key] += user.Value;
                    }
                }
            }

            int counter2 = 0;

            Console.WriteLine("Individual standings: ");
            foreach (var statistic in individualStatistics.OrderByDescending(points => points.Value).ThenBy(name => name.Key))
            {
                counter2++;

                Console.WriteLine($"{counter2}. {statistic.Key} -> {statistic.Value}");
            }
        }
    }
}
