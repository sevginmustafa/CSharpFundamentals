using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double convert = n * 0.001;

            Console.WriteLine($"{convert:f2}");
        }
    }
}
