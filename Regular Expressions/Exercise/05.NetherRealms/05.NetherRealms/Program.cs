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
            string digitsPattern = @"-?\d+\.?\d*";
            string symbolsPattern = @"[^0-9*\/*\-.+]";

            SortedDictionary<string, List<double>> demons = new SortedDictionary<string, List<double>>();

            string[] array = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < array.Length; i++)
            {

                MatchCollection symbols = Regex.Matches(array[i], symbolsPattern);

                double health = 0;

                foreach (var symbol in symbols)
                {
                    health += char.Parse(symbol.ToString());
                }

                MatchCollection digits = Regex.Matches(array[i], digitsPattern);

                double damage = digits.Select(x => double.Parse(x.Value)).Sum();

                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == '/')
                    {
                        damage /= 2;
                    }
                    else if (array[i][j] == '*')
                    {
                        damage *= 2;
                    }
                }

                if (demons.ContainsKey(array[i]))
                {
                    demons[array[i]].Add(health);
                    demons[array[i]].Add(damage);
                }
                else
                {
                    demons.Add(array[i], new List<double> { health, damage });
                }
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}

