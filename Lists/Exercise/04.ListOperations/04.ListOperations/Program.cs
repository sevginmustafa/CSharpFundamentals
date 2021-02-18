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

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    AddNumToList(nums, command);
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) >= nums.Count || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        InsertNumToGivenPosition(nums, command);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) >= nums.Count || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        RemoveNumFromGivenPosition(nums, command);
                    }
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        ShiftNumToLeftCountTimes(nums, command);
                    }
                    else
                    {
                        ShiftNumToRightCountTimes(nums, command);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', nums));
        }

        static List<int> AddNumToList(List<int> nums, string[] command)
        {
            nums.Add(int.Parse(command[1]));

            return nums;
        }

        static List<int> InsertNumToGivenPosition(List<int> nums, string[] command)
        {
            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));

            return nums;
        }

        static List<int> RemoveNumFromGivenPosition(List<int> nums, string[] command)
        {
            nums.RemoveAt(int.Parse(command[1]));

            return nums;
        }

        static List<int> ShiftNumToLeftCountTimes(List<int> nums, string[] command)
        {
            for (int i = 0; i < int.Parse(command[2]); i++)
            {
                nums.Add(nums[0]);
                nums.RemoveAt(0);
            }

            return nums;
        }

        static List<int> ShiftNumToRightCountTimes(List<int> nums, string[] command)
        {
            for (int i = 0; i < int.Parse(command[2]); i++)
            {
                nums.Insert(0, nums[nums.Count - 1]);
                nums.RemoveAt(nums.Count - 1);
            }

            return nums;
        }
    }
}
