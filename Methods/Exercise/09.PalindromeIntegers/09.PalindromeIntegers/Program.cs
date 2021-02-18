using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            while (num != "END")
            {
                Console.WriteLine(PalindromeInteger(num).ToString().ToLower());
                num = Console.ReadLine();
            }
        }

        static bool PalindromeInteger(string num)
        {
            var reversed = num.Reverse().ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[0] != reversed[0])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
