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
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentWord = arr[i];

                double number = int.Parse(currentWord.Substring(1, currentWord.Length - 2));
                int first = 0;
                int last = 0;

                if (char.IsUpper(currentWord[0]))
                {
                    first = currentWord[0] - 90 + 26;

                    result += number / first;
                }
                else
                {
                    first = currentWord[0] - 122 + 26;

                    result += number * first;
                }

                if (char.IsUpper(currentWord[currentWord.Length - 1]))
                {
                    last = currentWord[currentWord.Length - 1] - 90 + 26;

                    result -= last;
                }
                else
                {
                    last = currentWord[currentWord.Length - 1] - 122 + 26;

                    result += last;
                }
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
