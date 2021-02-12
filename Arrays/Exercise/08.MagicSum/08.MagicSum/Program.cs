using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            string output = "";

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum = int.Parse(nums[i]) + int.Parse(nums[j]);
                    if (sum == n)
                    {
                        Console.WriteLine(nums[i] + " " + nums[j]);
                    }
                }
            }
        }
    }
}
