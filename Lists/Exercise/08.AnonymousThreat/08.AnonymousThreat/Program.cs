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
            List<string> array = Console.ReadLine().Split().ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    string concat = string.Empty;

                    if ((startIndex < 0 || startIndex >= array.Count) && (endIndex <= 0 || endIndex >= array.Count))
                    {
                        startIndex = 0;
                        endIndex = array.Count - 1;
                    }

                    if (startIndex < 0)
                    {
                        if (endIndex >= 0 && endIndex < array.Count)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex >= array.Count)
                    {
                        if (startIndex >= 0 && startIndex < array.Count)
                        {
                            endIndex = array.Count - 1;
                        }
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concat += array[i];
                    }

                    array.RemoveRange(startIndex, endIndex - startIndex + 1);
                    array.Insert(startIndex, concat);
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);

                    string word = array[index];

                    int divider = word.Length / partition;

                    int startIndex = 0;

                    List<string> divideWord = new List<string>();

                    for (int i = 0; i < partition; i++)
                    {
                        if (i == partition - 1)
                        {
                            divideWord.Add(word.Substring(startIndex, word.Length - startIndex));
                            break;
                        }

                        divideWord.Add(word.Substring(startIndex, divider));
                        startIndex += divider;
                    }
                    array.RemoveAt(index);
                    array.InsertRange(index, divideWord);
                }
            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}
