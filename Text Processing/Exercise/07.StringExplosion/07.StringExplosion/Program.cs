﻿using System;
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
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (current == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(current);
                }
                else if (power == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
