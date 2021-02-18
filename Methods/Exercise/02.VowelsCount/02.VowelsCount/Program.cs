using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            VowelsCount(word);
        }

        static void VowelsCount(string input)
        {
            char[] vowels = { 'a', 'o', 'u', 'e', 'i' };
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
