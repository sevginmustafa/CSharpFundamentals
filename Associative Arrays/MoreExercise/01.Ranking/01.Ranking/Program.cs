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

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] splittedInput = input.Split(':');

                string contest = splittedInput[0];
                string contestPassword = splittedInput[1];

                if (contests.ContainsKey(contest))
                {
                    contests[contest] = contestPassword;
                }
                else
                {
                    contests.Add(contest, contestPassword);
                }
            }

            string input2 = string.Empty;

            SortedDictionary<string, Dictionary<string, int>> usersContests = new SortedDictionary<string, Dictionary<string, int>>();

            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] splittedInput2 = input2.Split("=>");

                string contest = splittedInput2[0];
                string contestPassword = splittedInput2[1];
                string username = splittedInput2[2];
                int points = int.Parse(splittedInput2[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == contestPassword)
                    {
                        if (!usersContests.ContainsKey(username))
                        {
                            usersContests.Add(username, new Dictionary<string, int>());
                        }

                        if (!usersContests[username].ContainsKey(contest))
                        {
                            usersContests[username].Add(contest, points);
                        }

                        if (points > usersContests[username][contest])
                        {
                            usersContests[username][contest] = points;
                        }
                    }
                }
            }



            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            foreach (var user in usersContests)
            {
                totalPoints.Add(user.Key, user.Value.Values.Sum());
            }

            int maxUserPoints = totalPoints.Values.Max();

            foreach (var points in totalPoints)
            {
                if (points.Value == maxUserPoints)
                {
                    Console.WriteLine($"Best candidate is {points.Key} with total {maxUserPoints} points.");
                }
            }

            Console.WriteLine("Ranking: ");

            foreach (var user in usersContests)
            {
                Console.WriteLine(user.Key);

                foreach (var contestAndPoints in user.Value.OrderByDescending(points => points.Value))
                {
                    Console.WriteLine($"#  {contestAndPoints.Key} -> {contestAndPoints.Value}");
                }
            }
        }
    }
}
