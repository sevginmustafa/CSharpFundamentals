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
            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                string name = "";
                string age = "";

                for (int j = 0; j < text.Length; j++)
                {
                    char check = text[j];

                    if (check == '@')
                    {
                        for (int k = j; k < text.Length; k++)
                        {
                            if (text[k + 1] == '|')
                            {
                                break;
                            }
                            name += text[k + 1];
                        }
                    }

                    if (check == '#')
                    {
                        for (int l = j; l < text.Length; l++)
                        {
                            if (text[l + 1] == '*')
                            {
                                break;
                            }
                            age += text[l + 1];
                        }
                    }
                }
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
