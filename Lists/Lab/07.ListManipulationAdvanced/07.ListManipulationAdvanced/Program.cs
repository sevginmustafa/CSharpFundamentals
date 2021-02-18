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

            int counter = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    AddNumToList(nums, command);
                    counter++;
                }
                else if (command[0] == "Remove")
                {
                    RemoveNumFromList(nums, command);
                    counter++;
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveNumFromListOfGivenIndex(nums, command);
                    counter++;
                }
                else if (command[0] == "Insert")
                {
                    InsertNumToList(nums, command);
                    counter++;
                }
                else if (command[0] == "Contains")
                {
                    CheckIfContains(nums, command);
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEvenNums(nums);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOddNums(nums);
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(PrintSum(nums));
                }
                else if (command[0] == "Filter")
                {
                    FilterListOfNums(nums, command);
                }
            }

            if (counter != 0)
            {
                Console.WriteLine(string.Join(' ', nums));
            }
        }

        static void AddNumToList(List<int> nums, string[] command)
        {
            nums.Add(int.Parse(command[1]));
        }

        static void RemoveNumFromList(List<int> nums, string[] command)
        {
            nums.Remove(int.Parse(command[1]));
        }

        static void RemoveNumFromListOfGivenIndex(List<int> nums, string[] command)
        {
            nums.RemoveAt(int.Parse(command[1]));
        }

        static void InsertNumToList(List<int> nums, string[] command)
        {
            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
        }

        static void CheckIfContains(List<int> nums, string[] command)
        {
            if (nums.Contains(int.Parse(command[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEvenNums(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void PrintOddNums(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static int PrintSum(List<int> nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        static void FilterListOfNums(List<int> nums, string[] command)
        {
            if (command[1] == "<")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] < int.Parse(command[2]))
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[1] == ">")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > int.Parse(command[2]))
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[1] == "<=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= int.Parse(command[2]))
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[1] == ">=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] >= int.Parse(command[2]))
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
