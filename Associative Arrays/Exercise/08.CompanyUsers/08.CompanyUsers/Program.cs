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

            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split(" -> ");

                string companyName = splittedInput[0];
                string employeeId = splittedInput[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
            }

            foreach (var pair in companies)
            {
                Console.WriteLine(pair.Key);

                for (int i = 0; i < pair.Value.Count; i++)
                {
                    Console.WriteLine("-- " + pair.Value[i]);
                }
            }
        }
    }
}
