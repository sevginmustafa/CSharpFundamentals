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
            List<int> bombNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bombNumber[0])
                {
                    if (i + bombNumber[1] > nums.Count - 1)
                    {
                        nums.RemoveRange(i + 1, nums.Count - i - 1);
                    }
                    else
                    {
                        nums.RemoveRange(i + 1, bombNumber[1]);
                    }
                }
                if (nums[i] == bombNumber[0])
                {
                    if (i - bombNumber[1] < 0)
                    {
                        nums.RemoveRange(0, i + 1);
                    }
                    else
                    {
                        nums.RemoveRange(i - bombNumber[1], bombNumber[1] + 1);
                    }
                    i = -1;
                }
            }

            Console.WriteLine(nums.Sum(i => i));
        }
    }
}
