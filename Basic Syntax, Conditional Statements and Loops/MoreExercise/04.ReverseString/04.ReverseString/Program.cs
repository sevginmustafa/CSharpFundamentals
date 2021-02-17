using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char current = input[i];
                reverse += current;
            }
            Console.WriteLine(reverse);
        }
    }
}
