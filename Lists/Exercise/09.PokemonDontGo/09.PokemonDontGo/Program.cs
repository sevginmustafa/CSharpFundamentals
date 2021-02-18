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
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            int temp = 0;
            int sum = 0;

            while (array.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= array.Count)
                {
                    temp = array[array.Count - 1];
                    array[array.Count - 1] = array[0];
                }
                else if (index < 0)
                {
                    temp = array[0];
                    array[0] = array[array.Count - 1];
                }
                else
                {
                    temp = array[index];
                    array.RemoveAt(index);
                }

                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] > temp)
                    {
                        array[i] -= temp;
                    }
                    else
                    {
                        array[i] += temp;
                    }
                }
                sum += temp;
            }

            Console.WriteLine(sum);
        }
    }
}
