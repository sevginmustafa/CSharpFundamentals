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

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    DeleteAllElementsEqualToGivenNum(nums, command);
                }
                else
                {
                    InsertElementToGivenPosition(nums, command);
                }
            }

            Console.WriteLine(string.Join(' ', nums));
        }

        static List<int> DeleteAllElementsEqualToGivenNum(List<int> nums, string[] command)
        {
            nums.RemoveAll(i => i == int.Parse(command[1]));

            return nums;
        }

        static List<int> InsertElementToGivenPosition(List<int> nums, string[] command)
        {
            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));

            return nums;
        }
    }
}
