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
            string word = Console.ReadLine();
            List<char> chars = word.ToList();

            for (int i = 0; i < chars.Count - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    chars.RemoveAt(i);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join("", chars));
        }
    }
}
