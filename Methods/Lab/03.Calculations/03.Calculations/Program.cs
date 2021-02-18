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
            string command = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (command == "add")
            {
                SumTwoNums(firstNum, secondNum);
            }
            else if (command == "substract")
            {
                SubstractTwoNums(firstNum, secondNum);
            }
            else if (command == "multiply")
            {
                MultiplyTwoNums(firstNum, secondNum);
            }
            else if (command == "divide")
            {
                DivideTwoNums(firstNum, secondNum);
            }
        }

        static void SumTwoNums(double one, double two)
        {
            Console.WriteLine(one + two);
        }

        static void SubstractTwoNums(double one, double two)
        {
            Console.WriteLine(one - two);
        }

        static void MultiplyTwoNums(double one, double two)
        {
            Console.WriteLine(one * two);
        }

        static void DivideTwoNums(double one, double two)
        {
            Console.WriteLine(one / two);
        }
    }
}

