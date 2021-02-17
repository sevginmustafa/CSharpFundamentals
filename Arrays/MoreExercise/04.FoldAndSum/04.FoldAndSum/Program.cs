using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int divider = nums.Length / 4;

            int[] topArray = new int[nums.Length / 2];
            int[] bottomArray = new int[nums.Length / 2];

            for (int i = 0; i < divider; i++)
            {
                topArray[divider - i - 1] = nums[i];
                topArray[topArray.Length - divider + i] = nums[nums.Length - 1 - i];
            }
            for (int i = 0; i < bottomArray.Length; i++)
            {
                bottomArray[i] = nums[divider + i];
            }

            int[] resultArray = new int[nums.Length / 2];

            for (int i = 0; i < nums.Length / 2; i++)
            {
                resultArray[i] = topArray[i] + bottomArray[i];
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}