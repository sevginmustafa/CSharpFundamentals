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

            double leftCar = 0;
            double rightCar = 0;

            for (int i = 0; i < nums.Count / 2; i++)
            {
                if (nums[i] == 0)
                {
                    leftCar *= 0.8;
                }
                else
                {
                    leftCar += nums[i];
                }
            }

            for (int j = nums.Count - 1; j > nums.Count / 2; j--)
            {
                if (nums[j] == 0)
                {
                    rightCar *= 0.8;
                }
                else
                {
                    rightCar += nums[j];
                }
            }

            if (rightCar >= leftCar)
            {
                Console.WriteLine($"The winner is left with total time: {leftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCar}");
            }
        }
    }
}
