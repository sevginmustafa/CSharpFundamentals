using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            char check = ' ';
            long sum = 0;
            int j = 0;

            for (int i = 0; i < N; i++)
            {
                string num = Console.ReadLine();
                string left = "";
                string right = "";

                for (j = 0; j < num.Length; j++)
                {
                    check = num[j];
                    if (check == ' ')
                    {
                        break;
                    }
                    left += num[j];
                }
                for (int k = j + 1; k < num.Length; k++)
                {
                    right += num[k];
                }

                long leftNum = long.Parse(left);
                long rightNum = long.Parse(right);
                long biggerNum = rightNum;

                if (leftNum > rightNum)
                {
                    biggerNum = leftNum;
                }

                while (biggerNum != 0)
                {
                    sum += biggerNum % 10;
                    biggerNum = biggerNum / 10;
                }
                Console.WriteLine(Math.Abs(sum));
                sum = 0;
            }
        }
    }
}
