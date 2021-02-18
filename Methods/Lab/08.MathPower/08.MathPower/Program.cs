using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateMathPower(n, power));
        }

        static double CalculateMathPower(double n, int power)
        {
            double result = Math.Pow(n, power);

            return result;
        }
    }
}
