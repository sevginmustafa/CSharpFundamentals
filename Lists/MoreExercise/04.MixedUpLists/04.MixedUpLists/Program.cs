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

            List<int> combined = new List<int>();

            int count = Math.Max(first.Count, second.Count);

            for (int i = 0; i < count; i++)
            {
                if (i < first.Count)
                {
                    combined.Add(first[i]);
                }
                if (i < second.Count)
                {
                    combined.Add(second[second.Count - 1 - i]);
                }
            }

            int startNum = Math.Min(combined[combined.Count - 1], combined[combined.Count - 2]);
            int endNum = Math.Max(combined[combined.Count - 1], combined[combined.Count - 2]);

            combined.RemoveRange(combined.Count - 2, 2);

            List<int> result = new List<int>();

            for (int i = 0; i < combined.Count; i++)
            {
                if (combined[i] > startNum && combined[i] < endNum)
                {
                    result.Add(combined[i]);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
