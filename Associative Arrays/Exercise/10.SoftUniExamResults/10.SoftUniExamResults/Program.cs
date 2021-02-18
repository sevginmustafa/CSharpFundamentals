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

            Dictionary<string, int> languageCount = new Dictionary<string, int>();
            Dictionary<string, int> studentsPoints = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] command = input.Split('-');

                string username = command[0];
                string language = command[1];

                if (language == "banned")
                {
                    studentsPoints.Remove(username);
                }
                else
                {
                    int points = int.Parse(command[2]);

                    if (languageCount.ContainsKey(language))
                    {
                        languageCount[language]++;
                    }
                    else
                    {
                        languageCount.Add(language, 1);
                    }

                    if (studentsPoints.ContainsKey(username))
                    {
                        if (studentsPoints[username] < points)
                        {
                            studentsPoints[username] = points;
                        }
                    }
                    else
                    {
                        studentsPoints.Add(username, points);
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (var student in studentsPoints.OrderByDescending(points => points.Value).ThenBy(username => username.Key))
            {
                Console.WriteLine(student.Key + " | " + student.Value);
            }

            Console.WriteLine("Submissions:");
            foreach (var language in languageCount.OrderByDescending(count => count.Value).ThenBy(language => language.Key))
            {
                Console.WriteLine(language.Key + " - " + language.Value);
            }
        }
    }
}
