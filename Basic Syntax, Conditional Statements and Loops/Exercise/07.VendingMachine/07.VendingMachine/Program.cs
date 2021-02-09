using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();

            double sum = 0;

            while (money != "Start")
            {
                double convert = double.Parse(money);
                if (convert == 0.1 || convert == 0.2 || convert == 0.5 || convert == 1 || convert == 2)
                {
                    sum += convert;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {convert}");
                }
                money = Console.ReadLine();
            }

            string product = Console.ReadLine();

            double price = 0;
            bool isValid = true;


            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        isValid = false;
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sum >= price && isValid)
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (isValid)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
