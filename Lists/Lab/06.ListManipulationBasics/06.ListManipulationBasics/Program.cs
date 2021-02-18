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

                if (command[0] == "Add")
                {
                    nums.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    nums.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
