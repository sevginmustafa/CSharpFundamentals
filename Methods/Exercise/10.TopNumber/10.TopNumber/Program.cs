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

            PrintTopNumbers(num);
        }

        static void PrintTopNumbers(int num)
        {
            for (int i = 17; i <= num; i++)
            {
                string check = i.ToString();
                int sum = 0;

                for (int j = 0; j < check.Length; j++)
                {
                    sum += check[j];
                }
                if (sum % 8 == 0)
                {
                    for (int k = 0; k < check.Length; k++)
                    {
                        if (check[k] % 2 == 1)
                        {
                            Console.WriteLine(check);
                            break;
                        }
                    }
                }
            }
        }
    }
}
