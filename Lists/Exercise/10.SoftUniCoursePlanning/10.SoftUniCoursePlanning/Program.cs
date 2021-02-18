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
            List<string> scheduleOfLessons = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":");

                if (command[0] == "Add")
                {
                    if (!scheduleOfLessons.Contains(command[1]))
                    {
                        scheduleOfLessons.Add(command[1]);
                    }
                }
                else if (command[0] == "Insert")
                {
                    if (!scheduleOfLessons.Contains(command[1]))
                    {
                        scheduleOfLessons.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (scheduleOfLessons.Contains(command[1]))
                    {
                        scheduleOfLessons.Remove(command[1]);
                        if (scheduleOfLessons.Contains(command[1] + "-Exercise"))
                        {
                            scheduleOfLessons.Remove(command[1] + "-Exercise");
                        }
                    }
                }
                else if (command[0] == "Swap")
                {
                    if (scheduleOfLessons.Contains(command[1]))
                    {
                        if (scheduleOfLessons.Contains(command[2]))
                        {
                            int indexOne = scheduleOfLessons.IndexOf(command[1]);
                            int indexTwo = scheduleOfLessons.IndexOf(command[2]);

                            scheduleOfLessons[indexOne] = command[2];
                            scheduleOfLessons[indexTwo] = command[1];

                            if (scheduleOfLessons.Contains(command[1] + "-Exercise"))
                            {
                                scheduleOfLessons.Remove(command[1] + "-Exercise");
                                scheduleOfLessons.Insert(indexTwo + 1, command[1] + "-Exercise");

                            }
                            if (scheduleOfLessons.Contains(command[2] + "-Exercise"))
                            {
                                scheduleOfLessons.Remove(command[2] + "-Exercise");
                                scheduleOfLessons.Insert(indexOne + 1, command[2] + "-Exercise");
                            }
                        }
                    }
                }
                else
                {
                    if (scheduleOfLessons.Contains(command[1]) && scheduleOfLessons.Contains(command[1] + "-Exercise"))
                    {
                        continue;
                    }
                    if (scheduleOfLessons.Contains(command[1]))
                    {
                        int index = scheduleOfLessons.IndexOf(command[1]);
                        scheduleOfLessons.Insert(index + 1, command[1] + "-Exercise");
                    }
                    else
                    {
                        scheduleOfLessons.Add(command[1]);
                        scheduleOfLessons.Add(command[1] + "-Exercise");
                    }
                }
            }

            for (int i = 0; i < scheduleOfLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{scheduleOfLessons[i]}");
            }
        }
    }
}
