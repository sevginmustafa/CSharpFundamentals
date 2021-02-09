using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < n + 97; i++)
            {
                for (int j = 'a'; j < n + 97; j++)
                {
                    for (int k = 'a'; k < n + 97; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
