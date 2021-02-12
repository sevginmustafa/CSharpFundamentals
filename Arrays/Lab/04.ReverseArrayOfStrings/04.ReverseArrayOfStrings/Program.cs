using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[input.Length - i - 1] + " ");
            }
        }
    }
}
