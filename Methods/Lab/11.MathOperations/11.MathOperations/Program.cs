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
            double firstNum = double.Parse(Console.ReadLine());
            char operatorSign = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Calculatation(firstNum, operatorSign, secondNum)}");
        }

        static double Calculatation(double first, char operatorSign, double second)
        {
            if (operatorSign == '+')
            {
                return first + second;
            }
            else if (operatorSign == '-')
            {
                return first - second;
            }
            else if (operatorSign == '*')
            {
                return first * second;
            }
            else
            {
                return first / second;
            }
        }
    }
}

