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
            string text = Console.ReadLine();

            int startIndex = text.IndexOf(word);

            while (startIndex != -1)
            {
                text = text.Remove(startIndex, word.Length);
                startIndex = text.IndexOf(word);
            }

            Console.WriteLine(text);
        }
    }
}
