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
            string message = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < nums.Count; i++)
            {
                int temp = nums[i];
                int sum = 0;

                while (temp != 0)
                {
                    sum += temp % 10;
                    temp = temp / 10;
                }

                while (sum >= message.Length)
                {
                    sum -= message.Length;
                }

                output.Append(message[sum]);
                message = message.Remove(sum, 1);
            }
            Console.WriteLine(output);
        }
    }
}
