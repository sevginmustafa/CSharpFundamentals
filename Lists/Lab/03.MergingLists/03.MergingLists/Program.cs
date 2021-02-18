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
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int biggessttList = Math.Max(first.Count, second.Count);

            for (int i = 0; i < biggessttList; i++)
            {
                if (first.Count > i)
                {
                    result.Add(first[i]);
                }
                if (second.Count > i)
                {
                    result.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
