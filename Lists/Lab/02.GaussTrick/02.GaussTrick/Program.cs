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
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count / 2; i++)
            {
                int sum = nums[i] + nums[nums.Count - 1 - i];

                Console.Write(sum + " ");
            }
            if (nums.Count % 2 == 1)
            {
                Console.Write(nums[nums.Count / 2]);
            }
        }
    }
}
