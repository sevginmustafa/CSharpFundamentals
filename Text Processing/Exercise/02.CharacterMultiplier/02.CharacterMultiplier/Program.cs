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
            string[] input = Console.ReadLine().Split();

            Console.WriteLine(CharMultiplier(input));
        }

        public static int CharMultiplier(string[] arr)
        {
            int sum = 0;

            string max = "";
            string min = "";

            if (arr[0].Length >= arr[1].Length)
            {
                max = arr[0];
                min = arr[1];
            }
            else if (arr[0].Length < arr[1].Length)
            {
                max = arr[1];
                min = arr[0];
            }

            for (int i = 0; i < min.Length; i++)
            {
                sum += arr[0][i] * arr[1][i];
            }

            max = max.Substring(min.Length);

            sum += max.Sum(x => x);

            return sum;
        }

    }
}
