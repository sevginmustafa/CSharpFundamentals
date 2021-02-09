using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLightsaberPrice = (Math.Ceiling(students * 1.1)) * lightsaberPrice;
            double totalBeltPrice = (students * 1.0 * beltPrice) - ((students / 6) * beltPrice);
            double totalRobePrice = students * 1.0 * robePrice;
            double total = totalLightsaberPrice + totalBeltPrice + totalRobePrice;

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - money:f2}lv more.");
            }
        }
    }
}
