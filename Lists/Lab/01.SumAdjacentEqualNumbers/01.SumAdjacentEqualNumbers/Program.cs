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
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums.Insert(i, nums[i] + nums[i + 1]);
                    nums.RemoveRange(i + 1, 2);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
