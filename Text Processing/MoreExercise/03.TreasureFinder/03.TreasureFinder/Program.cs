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
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "find")
            {
                string result = "";

                bool isOver = false;
                int counter = 0;

                while (!isOver)
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        int check = input[counter] - key[i];

                        if (counter == input.Length - 1)
                        {
                            check = input[input.Length - 1] - key[i];
                            result += (char)check;
                            isOver = true;
                            break;
                        }

                        result += (char)check;
                        counter++;
                    }
                }
                int typeStart = result.IndexOf('&');
                int typeEnd = result.LastIndexOf('&');

                int coordinatesStart = result.IndexOf('<');
                int coordinatesEnd = result.IndexOf('>');

                string type = result.Substring(typeStart + 1, typeEnd - typeStart - 1);
                string coordinates = result.Substring(coordinatesStart + 1, coordinatesEnd - coordinatesStart - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
