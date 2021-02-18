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
            string text = Console.ReadLine();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }
                if (dictionary.ContainsKey(text[i]))
                {
                    dictionary[text[i]]++;
                }
                else
                {
                    dictionary.Add(text[i], 1);
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
