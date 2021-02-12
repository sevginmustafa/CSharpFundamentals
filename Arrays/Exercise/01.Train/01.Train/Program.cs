using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[j] + " ");
                sum += array[j];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
