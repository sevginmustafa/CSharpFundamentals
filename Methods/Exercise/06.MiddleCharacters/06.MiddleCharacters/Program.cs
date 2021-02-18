using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(PrintMiddleCharacters(input));
        }

        static string PrintMiddleCharacters(string word)
        {
            if (word.Length % 2 == 0)
            {
                return word[word.Length / 2 - 1] + word[word.Length / 2].ToString();
            }
            else
            {
                return word[word.Length / 2].ToString();
            }
        }
    }
}
