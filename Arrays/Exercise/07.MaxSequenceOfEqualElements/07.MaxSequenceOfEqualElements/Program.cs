using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string output = "";
            string totalOutput = "";

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        output += nums[j] + " ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (output.Length > totalOutput.Length)
                {
                    totalOutput = output;
                }
                output = "";
            }
            Console.WriteLine(totalOutput);
        }
    }
}
