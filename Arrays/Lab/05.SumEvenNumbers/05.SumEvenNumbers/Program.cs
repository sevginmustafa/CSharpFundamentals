using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[input.Length];

            int sumEvenNumbers = 0;
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
                if (numbers[i] % 2 == 0)
                {
                    sumEvenNumbers += numbers[i];
                }
            }
            Console.WriteLine(sumEvenNumbers);
        }
    }
}
