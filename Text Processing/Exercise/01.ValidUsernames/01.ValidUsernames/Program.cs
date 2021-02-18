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
            string[] arr = Console.ReadLine().Split(", ");

            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                int counter = 0;

                if (word.Length >= 4 && word.Length <= 15)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        char check = word[j];

                        if (!char.IsLetterOrDigit(check) && check != '-' && check != '_')
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    counter++;
                }

                if (counter == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
