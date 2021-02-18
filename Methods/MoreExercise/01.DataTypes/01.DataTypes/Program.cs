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
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();

            if (dataType == "int")
            {
                Console.WriteLine(PrintInt(dataType, input));
            }
            else if (dataType == "real")
            {
                Console.WriteLine($"{PrintDouble(dataType, input):f2}");
            }
            else
            {
                PrintString(input);
            }
        }

        static int PrintInt(string command, string input)
        {
            return int.Parse(input) * 2;
        }

        static double PrintDouble(string command, string input)
        {
            return double.Parse(input) * 1.5;
        }

        static void PrintString(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}

