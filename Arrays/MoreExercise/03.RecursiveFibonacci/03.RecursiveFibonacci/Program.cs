using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            long[] array = new long[n];

            if (array.Length < 3)
            {
                Console.WriteLine(1);
                return;
            }

            array[0] = 1;
            array[1] = 1;

            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}