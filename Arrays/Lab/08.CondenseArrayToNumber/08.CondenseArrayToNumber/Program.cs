using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            while (nums.Length != 1)
            {
                int[] newArray = new int[nums.Length - 1];

                for (int j = 0; j < newArray.Length; j++)
                {
                    newArray[j] = nums[j] + nums[j + 1];
                }
                nums = newArray;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
