using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfDigits(n, 0) * GetSumOfDigits(n, 1); ;
        }
        static int GetSumOfDigits(int n, int isOdd)
        {
            string num = n.ToString();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int number = int.Parse(num[i].ToString());
                if (number % 2 == isOdd)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
