using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@{6,}|\${6,}|#{6,}|\^{6,}";

            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    string ticketLeft = tickets[i].Substring(0, 10);
                    string ticketRight = tickets[i].Substring(10, 10);

                    Match left = Regex.Match(ticketLeft, pattern);
                    Match right = Regex.Match(ticketRight, pattern);

                    if (left.Success && right.Success)
                    {
                        string min = left.ToString();

                        if (left.Length > right.Length)
                        {
                            min = right.ToString();
                        }

                        if (min.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - 10{min[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {min.Length}{min[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}

