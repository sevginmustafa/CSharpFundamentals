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
            string digitsPattern = @"\d+";
            string symbolsPattern = @"[^\d]+";

            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            List<char> specialSymbols = new List<char>();

            MatchCollection digits = Regex.Matches(input, digitsPattern);
            MatchCollection symbols = Regex.Matches(input, symbolsPattern);

            List<int> digitsList = digits.Select(x => int.Parse(x.Value)).ToList();
            List<string> symbolsList = symbols.Select(x => x.Value.ToString().ToUpper()).ToList();

            for (int i = 0; i < symbolsList.Count; i++)
            {
                if (digitsList[i] > 0)
                {
                    for (int j = 0; j < digitsList[i]; j++)
                    {
                        result.Append(symbolsList[i]);
                    }

                    for (int k = 0; k < symbolsList[i].Length; k++)
                    {
                        if (!specialSymbols.Contains(symbolsList[i][k]))
                        {
                            specialSymbols.Add(symbolsList[i][k]);
                        }
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {specialSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}

