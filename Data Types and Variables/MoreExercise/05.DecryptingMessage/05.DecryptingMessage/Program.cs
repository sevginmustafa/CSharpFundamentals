using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string word = "";

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int convert = key + character;
                word += (char)convert;
            }
            Console.WriteLine(word);
        }
    }
}