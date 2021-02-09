using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int i = multiplier;

            do
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i++;
            }
            while (i <= 10);
        }
    }
}
