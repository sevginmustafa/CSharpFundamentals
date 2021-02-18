using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringFast(input, n));
        }

        static string RepeatStringFast(string output, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(output);
            }
            return result.ToString();
        }
    }
}
