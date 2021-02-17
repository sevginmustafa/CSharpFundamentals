using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isPrimeNum = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNum = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrimeNum.ToString().ToLower()}");
            }
        }
    }
}