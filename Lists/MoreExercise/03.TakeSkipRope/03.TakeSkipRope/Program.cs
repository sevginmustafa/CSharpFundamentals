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

            List<char> digits = new List<char>();
            List<char> symbols = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    digits.Add(input[i]);

                }
                else
                {
                    symbols.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                int check = int.Parse(digits[i].ToString());

                if (i % 2 == 0)
                {
                    takeList.Add(check);
                }
                else
                {
                    skipList.Add(check);
                }
            }

            StringBuilder result = new StringBuilder();

            int counter = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (counter == symbols.Count)
                    {
                        break;
                    }
                    result.Append(symbols[counter]);
                    counter++;
                }
                for (int k = 0; k < skipList[i]; k++)
                {
                    if (counter == symbols.Count)
                    {
                        break;
                    }
                    counter++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
