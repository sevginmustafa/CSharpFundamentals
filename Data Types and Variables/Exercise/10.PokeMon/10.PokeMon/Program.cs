using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());

            float halfPokePower = N / 2f;
            int count = 0;

            while (N >= M)
            {
                if (halfPokePower == N && Y != 0)
                {
                    N /= Y;
                }
                if (N < M)
                {
                    break;
                }
                N -= M;
                count++;
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
