using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sort = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    char check = input[j];
                    if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u' || check == 'A' || check == 'E' || check == 'I' || check == 'O' || check == 'U')
                    {
                        sum += check * input.Length;
                    }
                    else
                    {
                        sum += check / input.Length;
                    }
                }
                for (int k = 0; k < n; k++)
                {
                    sort[i] = sum;
                }
            }

            int temp = 0;

            for (int i = 0; i < sort.Length - 1; i++)
            {
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[i] > sort[j])
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                }
            }

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
        }
    }
}
