using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] product = input.Split();

                string productName = product[0];
                double productPrice = double.Parse(product[1]);
                int quantity = int.Parse(product[2]);

                if (orders.ContainsKey(productName))
                {
                    orders[productName][0] = productPrice;
                    orders[productName][1] += quantity;
                }
                else
                {
                    orders.Add(productName, new List<double>());
                    orders[productName].Add(productPrice);
                    orders[productName].Add(quantity);
                }
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key} -> {order.Value[0] * order.Value[1]:f2}");
            }
        }
    }
}
