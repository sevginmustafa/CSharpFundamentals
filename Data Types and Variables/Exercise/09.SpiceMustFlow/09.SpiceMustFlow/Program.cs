using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int total = 0;
            int days = 0;

            for (int yield = startingYield; yield >= 100; yield -= 10)
            {
                int consumation = yield - 26;
                total += consumation;
                days++;
            }
            if (total > 0)
            {
                total -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine((int)Math.Abs(total));
        }
    }
}
