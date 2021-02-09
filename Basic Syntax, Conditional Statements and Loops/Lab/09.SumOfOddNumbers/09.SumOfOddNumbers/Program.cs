using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    counter++;
                    if (counter <= n)
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
