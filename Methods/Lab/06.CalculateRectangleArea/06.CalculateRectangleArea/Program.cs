using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintRectangleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        static int PrintRectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
