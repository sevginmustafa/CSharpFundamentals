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
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            PrintClosestPointsInCoordinateSystem(x1, y1, x2, y2, X1, Y1, X2, Y2);
        }

        static void PrintClosestPointsInCoordinateSystem(double x1, double y1, double x2, double y2, double X1, double Y1, double X2, double Y2)
        {
            double resultOne = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double resultTwo = Math.Abs(X1) + Math.Abs(Y1) + Math.Abs(X2) + Math.Abs(Y2);


            if (resultOne >= resultTwo)
            {
                if ((Math.Abs(x1) + Math.Abs(y1)) <= (Math.Abs(x2) + Math.Abs(y2)))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }

            else
            {
                if ((Math.Abs(X1) + Math.Abs(Y1)) <= (Math.Abs(X2) + Math.Abs(Y2)))
                {
                    Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
                }
                else
                {
                    Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
                }
            }
        }
    }
}

