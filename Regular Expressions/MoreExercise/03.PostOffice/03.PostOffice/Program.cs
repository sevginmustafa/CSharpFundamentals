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
            string firstPattern = @"([#$%&*])(?<capitalLetters>[A-Z]+)\1";
            string secondPattern = @"(?<asciiCode>\d+):(?<length>\d{2})";

            string[] input = Console.ReadLine().Split('|').ToArray();

            Match findCapitalLetters = Regex.Match(input[0], firstPattern);

            List<char> capitalLetters = findCapitalLetters.ToString().ToList();



            MatchCollection findStartingLetterAndLength = Regex.Matches(input[1], secondPattern);

            Dictionary<char, int> startingLetterAndLength = new Dictionary<char, int>();

            for (int i = 0; i < capitalLetters.Count; i++)
            {
                foreach (Match match in findStartingLetterAndLength)
                {
                    if (capitalLetters[i] == (char)int.Parse(match.Groups["asciiCode"].Value))
                    {
                        startingLetterAndLength.Add(capitalLetters[i], int.Parse(match.Groups["length"].Value));
                        break;
                    }
                }
            }



            List<string> words = input[2].Split().ToList();

            List<string> result = new List<string>();

            foreach (var item in startingLetterAndLength)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (item.Key == words[i][0] && words[i].Length == item.Value + 1)
                    {
                        result.Add(words[i]);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}

