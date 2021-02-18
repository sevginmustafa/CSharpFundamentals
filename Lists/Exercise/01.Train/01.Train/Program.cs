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
            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    nums.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (maxWagonCapacity >= nums[i] + int.Parse(command[0]))
                        {
                            nums[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
