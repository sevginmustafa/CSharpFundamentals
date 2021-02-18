using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char from = char.Parse(Console.ReadLine());
            char to = char.Parse(Console.ReadLine());

            CharactersInRange(from, to);
        }

        static void CharactersInRange(char from, char to)
        {
            if (from < to)
            {
                for (int i = from + 1; i < to; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = to + 1; i < from; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
