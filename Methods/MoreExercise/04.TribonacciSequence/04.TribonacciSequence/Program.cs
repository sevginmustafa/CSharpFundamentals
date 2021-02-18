using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacciSequence(num);
        }

        static void PrintTribonacciSequence(int num)
        {
            int[] array = new int[num];

            array[0] = 1;

            for (int i = 1; i < num; i++)
            {
                int counter = 1;

                for (int j = i; j > 0; j--)
                {
                    array[i] += array[i - counter];
                    counter++;
                    if (counter == 4)
                    {
                        break;
                    }
                }

            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}

