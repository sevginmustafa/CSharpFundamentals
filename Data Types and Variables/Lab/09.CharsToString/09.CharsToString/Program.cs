using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            string combined = one.ToString() + two.ToString() + three.ToString();

            Console.WriteLine(combined);
        }
    }
}
