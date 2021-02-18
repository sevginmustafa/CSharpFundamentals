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
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).ToList();

            List<int> biggestNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i == 3)
                {
                    break;
                }
                biggestNums.Add(nums[i]);
            }

            Console.WriteLine(string.Join(" ", biggestNums));
        }
    }
}
