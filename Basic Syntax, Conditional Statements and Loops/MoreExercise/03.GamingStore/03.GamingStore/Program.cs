using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double price = 0;
            double sum = 0;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        continue;
                }
                if (price > balance)
                {
                    Console.WriteLine("Too Expensive");
                    game = Console.ReadLine();
                    continue;
                }
                sum += price;
                balance -= price;
                Console.WriteLine($"Bought {game}");
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }
            if (game == "Game Time")
            {
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
