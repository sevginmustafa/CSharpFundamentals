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
            int firstNum = Math.Abs(int.Parse(Console.ReadLine()));
            int secondNum = Math.Abs(int.Parse(Console.ReadLine()));

            decimal result = FactorialDivision(firstNum) / FactorialDivision(secondNum);

            Console.WriteLine($"{result:f2}");
        }

        static decimal FactorialDivision(int num)
        {
            decimal factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
