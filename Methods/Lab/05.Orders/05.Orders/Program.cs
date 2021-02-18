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
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateProductPrice(product, quantity);
        }

        static void CalculateProductPrice(string product, int quantity)
        {
            double total = 0;

            switch (product)
            {
                case "coffee":
                    total = quantity * 1.5;
                    break;
                case "water":
                    total = quantity * 1;
                    break;
                case "coke":
                    total = quantity * 1.4;
                    break;
                case "snacks":
                    total = quantity * 2;
                    break;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}

