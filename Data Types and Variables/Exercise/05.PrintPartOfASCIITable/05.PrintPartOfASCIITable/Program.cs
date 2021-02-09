using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= lastChar; i++)
            {
                char current = (char)i;
                Console.Write(current + " ");
            }
        }
    }
}
