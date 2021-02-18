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
            List<Box> boxes = new List<Box>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var currentBox = input.Split().ToArray();
                string serialNumber = currentBox[0];
                string itemName = currentBox[1];
                int itemQuantity = int.Parse(currentBox[2]);
                double itemPrice = double.Parse(currentBox[3]);

                Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice, itemQuantity * itemPrice);
                boxes.Add(box);
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(box.ToString());
            }
        }

        public class Box
        {
            public string SerialNumber { get; set; }
            public string ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public double ItemPrice { get; set; }
            public double PriceForABox { get; set; }

            public Box(string serialNumber, string itemName, int itemQuantity, double itemPrice, double priceForABox)
            {
                this.SerialNumber = serialNumber;
                this.ItemName = itemName;
                this.ItemQuantity = itemQuantity;
                this.ItemPrice = itemPrice;
                this.PriceForABox = priceForABox;
            }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder();
                result.AppendLine(SerialNumber);
                result.AppendLine($"-- {ItemName} - ${ItemPrice:f2}: {ItemQuantity}");
                result.AppendLine($"-- ${PriceForABox:f2}");

                return result.ToString().TrimEnd();
            }
        }
    }
}
