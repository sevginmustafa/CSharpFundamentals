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
            string input = Console.ReadLine();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            while (input != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (dictionary.ContainsKey(input))
                {
                    dictionary[input] += value;
                }
                else
                {
                    dictionary.Add(input, value);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
