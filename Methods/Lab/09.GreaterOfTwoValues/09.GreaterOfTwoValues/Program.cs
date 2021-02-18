﻿using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        static string GetMax(string first, string second)
        {
            int compare = first.CompareTo(second);

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static int GetMax(int first, int second)
        {
            int compare = first.CompareTo(second);

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            int compare = first.CompareTo(second);

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
