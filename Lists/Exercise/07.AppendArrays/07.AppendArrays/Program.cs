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
            List<string> array = Console.ReadLine().Split('|').ToList();

            List<string> currentArray = new List<string>();

            StringBuilder result = new StringBuilder();

            for (int i = array.Count - 1; i >= 0; i--)
            {
                currentArray = array[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < currentArray.Count; j++)
                {
                    result.Append(currentArray[j] + " ");
                }

            }

            Console.WriteLine(result);
        }
    }
}
