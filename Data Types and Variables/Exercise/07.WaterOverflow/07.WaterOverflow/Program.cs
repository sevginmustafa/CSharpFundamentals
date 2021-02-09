using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            int total = 0;
            int capacity = 255;

            for (int i = 0; i < numOfLines; i++)
            {
                int quantitiyOfWater = int.Parse(Console.ReadLine());

                if (quantitiyOfWater > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                total += quantitiyOfWater;
                capacity -= quantitiyOfWater;
            }
            Console.WriteLine(total);
        }
    }
}
