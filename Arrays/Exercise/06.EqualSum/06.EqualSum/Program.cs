using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;

            if (nums.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += nums[j];
                }
                for (int k = i + 1; k < nums.Length; k++)
                {
                    sumRight += nums[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    sumLeft = 0;
                    sumRight = 0;
                }
            }
            Console.WriteLine("no");
        }
    }
}
