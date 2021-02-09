using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = (Console.ReadLine());
            int numConverted = int.Parse(num);

            int converted = 0;
            int totalSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currentSum = 1;
                char check = num[i];
                converted = int.Parse(check.ToString());

                for (int j = converted; j > 0; j--)
                {
                    currentSum *= j;
                }
                totalSum += currentSum;
                if (totalSum == numConverted)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
