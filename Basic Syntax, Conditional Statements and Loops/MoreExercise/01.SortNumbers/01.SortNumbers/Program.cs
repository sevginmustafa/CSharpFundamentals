using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double max = Math.Max(Math.Max(num1, num2), num3);
            double min = Math.Min(Math.Min(num1, num2), num3);
            double average = (num1 + num2 + num3) - (max + min);

            Console.WriteLine(max);
            Console.WriteLine(average);
            Console.WriteLine(min);
        }
    }
}
