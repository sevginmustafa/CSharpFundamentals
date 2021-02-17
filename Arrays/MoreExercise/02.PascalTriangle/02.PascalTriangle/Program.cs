using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            int[] checkArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] firstRow = new int[i];

                if (firstRow.Length < 3)
                {
                    firstRow[0] = 1;
                    firstRow[firstRow.Length - 1] = 1;
                }
                else
                {
                    firstRow[0] = 1;
                    for (int j = 0; j < firstRow.Length; j++)
                    {
                        for (int k = j + 1; k < firstRow.Length - 1; k++)
                        {
                            firstRow[k] = checkArray[j] + checkArray[j + 1];
                        }
                    }
                    firstRow[firstRow.Length - 1] = 1;
                }
                checkArray = firstRow.ToArray();
                Console.WriteLine(string.Join(" ", firstRow));
            }
        }
    }
}