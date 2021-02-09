using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 100; n++)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
