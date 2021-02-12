using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().ToArray();

            string currentTopNumber = "";
            string topNumbers = "";

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (int.Parse(nums[i]) > int.Parse(nums[j]))
                    {
                        currentTopNumber = nums[i];
                    }
                    else
                    {
                        currentTopNumber = "";
                        break;
                    }
                }
                if (currentTopNumber != "")
                {
                    topNumbers += currentTopNumber + " ";
                }
            }
            Console.WriteLine(topNumbers + nums[nums.Length - 1]);
        }
    }
}
