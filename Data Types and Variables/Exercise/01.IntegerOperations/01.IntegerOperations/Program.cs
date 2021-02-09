using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            Console.WriteLine((one + two) / three * four);
        }
    }
}
