using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] <= 57 && text[i] >= 48)
                {
                    digits.Append(text[i]);
                }
                else if ((text[i] <= 90 && text[i] >= 65) || (text[i] <= 122 && text[i] >= 97))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    others.Append(text[i]);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
