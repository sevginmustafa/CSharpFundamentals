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
            string[] path = Console.ReadLine().Split("\\");

            string[] word = path[path.Length - 1].Split('.');

            Console.WriteLine($"File name: {word[0]}");
            Console.WriteLine($"File extension: {word[1]}");
        }
    }
}
