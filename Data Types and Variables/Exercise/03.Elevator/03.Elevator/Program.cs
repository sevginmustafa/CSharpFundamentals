using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double result = Math.Ceiling(n / (p * 1.0));

            Console.WriteLine(result);
        }
    }
}
