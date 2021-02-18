using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = (double.Parse(Console.ReadLine()));
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPointsInCoordinateSystem(x1, y1, x2, y2);
        }

        static void PrintClosestPointsInCoordinateSystem(double x1, double y1, double x2, double y2)
        {
            double resultOne = Math.Abs(x1) + Math.Abs(y1);
            double resultTwo = Math.Abs(x2) + Math.Abs(y2);

            if (resultOne < resultTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}

