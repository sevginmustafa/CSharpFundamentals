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
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> nums = new SortedDictionary<double, int>();

            foreach (var num in list)
            {
                if (nums.ContainsKey(num))
                {
                    nums[num]++;
                }
                else
                {
                    nums.Add(num, 1);
                }
            }

            foreach (var pair in nums)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
