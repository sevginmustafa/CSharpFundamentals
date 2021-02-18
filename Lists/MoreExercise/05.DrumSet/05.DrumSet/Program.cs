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
            double savings = double.Parse(Console.ReadLine());
            List<short> drumSetQualityNums = Console.ReadLine().Split().Select(short.Parse).ToList();

            List<short> copyDrumSetQualityNums = drumSetQualityNums.ToList();

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                short hitPoints = short.Parse(input);

                for (int i = 0; i < drumSetQualityNums.Count; i++)
                {
                    drumSetQualityNums[i] -= hitPoints;

                    if (drumSetQualityNums[i] <= 0)
                    {
                        if (savings >= copyDrumSetQualityNums[i] * 3)
                        {
                            savings -= copyDrumSetQualityNums[i] * 3;
                            drumSetQualityNums[i] = copyDrumSetQualityNums[i];
                        }
                        else
                        {
                            drumSetQualityNums.RemoveAt(i);
                            copyDrumSetQualityNums.RemoveAt(i);
                            i--;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', drumSetQualityNums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
