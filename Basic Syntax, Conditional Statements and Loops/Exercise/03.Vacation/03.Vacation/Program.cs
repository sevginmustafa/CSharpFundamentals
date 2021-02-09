using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        price = 8.45;
                        if (number >= 30)
                        {
                            price *= 0.85;
                        }
                    }
                    else if (type == "Business")
                    {
                        price = 10.9;
                        if (number >= 100)
                        {
                            number -= 10;
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = 15;
                        if (number >= 10 && number <= 20)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        price = 9.8;
                        if (number >= 30)
                        {
                            price *= 0.85;
                        }
                    }
                    else if (type == "Business")
                    {
                        price = 15.6;
                        if (number >= 100)
                        {
                            number -= 10;
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = 20;
                        if (number >= 10 && number <= 20)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        price = 10.46;
                        if (number >= 30)
                        {
                            price *= 0.85;
                        }
                    }
                    else if (type == "Business")
                    {
                        price = 16;
                        if (number >= 100)
                        {
                            number -= 10;
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = 22.5;
                        if (number >= 10 && number <= 20)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {number * price:f2}");
        }
    }
}
