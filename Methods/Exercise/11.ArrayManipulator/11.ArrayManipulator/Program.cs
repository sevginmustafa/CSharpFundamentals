using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > initialArray.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    ExchangeIndexesInArray(initialArray, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        PrintMaxEven(initialArray);
                    }
                    else if (command[1] == "odd")
                    {
                        PrintMaxOdd(initialArray);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        PrintMinEven(initialArray);
                    }
                    else if (command[1] == "odd")
                    {
                        PrintMinOdd(initialArray);
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);

                    if (count <= initialArray.Length)
                    {
                        if (command[2] == "even")
                        {
                            PrintFirstEvens(initialArray, count);
                        }
                        else if (command[2] == "odd")
                        {
                            PrintFirstOdds(initialArray, count);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);

                    if (count <= initialArray.Length)
                    {
                        if (command[2] == "even")
                        {
                            PrintLastEvens(initialArray, count);
                        }
                        else if (command[2] == "odd")
                        {
                            PrintLastOdds(initialArray, count);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", initialArray)}]");
        }

        static void ExchangeIndexesInArray(int[] initialArray, int index)
        {
            int[] firstArray = new int[initialArray.Length - index - 1];
            int[] secondArray = new int[index + 1];
            int counter = 0;

            for (int i = index + 1; i < initialArray.Length; i++)
            {
                firstArray[counter] = initialArray[i];
                counter++;
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = initialArray[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                initialArray[i] = firstArray[i];
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                initialArray[firstArray.Length + i] = secondArray[i];
            }
        }

        static void PrintMaxEven(int[] initialArray)
        {
            int maxEvenNum = int.MinValue;
            int maxEvenIndex = -1;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] % 2 == 0)
                {
                    if (initialArray[i] >= maxEvenNum)
                    {
                        maxEvenNum = initialArray[i];
                        maxEvenIndex = i;
                    }
                }
            }
            if (maxEvenIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenIndex);
            }
        }

        static void PrintMaxOdd(int[] initialArray)
        {
            int maxOddNum = int.MinValue;
            int maxOddIndex = -1;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] % 2 == 1)
                {
                    if (initialArray[i] >= maxOddNum)
                    {
                        maxOddNum = initialArray[i];
                        maxOddIndex = i;
                    }
                }
            }
            if (maxOddIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddIndex);
            }
        }

        static void PrintMinEven(int[] initialArray)
        {
            int minEvenNum = int.MaxValue;
            int minEvenIndex = -1;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] % 2 == 0)
                {
                    if (initialArray[i] <= minEvenNum)
                    {
                        minEvenNum = initialArray[i];
                        minEvenIndex = i;
                    }
                }
            }
            if (minEvenIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenIndex);
            }
        }

        static void PrintMinOdd(int[] initialArray)
        {
            int minOddNum = int.MaxValue;
            int minOddIndex = -1;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] % 2 == 1)
                {

                    if (initialArray[i] <= minOddNum)
                    {
                        minOddNum = initialArray[i];
                        minOddIndex = i;
                    }
                }
            }
            if (minOddIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddIndex);
            }
        }

        static void PrintFirstEvens(int[] initialArray, int count)
        {
            int[] currentArray = new int[count];
            int counter = 0;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] % 2 == 0)
                {
                    currentArray[counter] = initialArray[i];
                    counter++;
                    if (counter == currentArray.Length)
                    {
                        break;
                    }
                }
            }
            int[] firstEvens = new int[counter];

            for (int i = 0; i < firstEvens.Length; i++)
            {
                firstEvens[i] = currentArray[i];
            }

            if (counter != 0)
            {
                Console.WriteLine($"[{string.Join(", ", firstEvens)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void PrintFirstOdds(int[] initialArray, int count)
        {
            int[] currentArray = new int[count];
            int counter = 0;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] % 2 == 1)
                {
                    currentArray[counter] = initialArray[i];
                    counter++;
                    if (counter == currentArray.Length)
                    {
                        break;
                    }
                }
            }

            int[] firstOdds = new int[counter];

            for (int i = 0; i < firstOdds.Length; i++)
            {
                firstOdds[i] = currentArray[i];
            }

            if (counter != 0)
            {
                Console.WriteLine($"[{string.Join(", ", firstOdds)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void PrintLastEvens(int[] initialArray, int count)
        {
            int[] currentArray = new int[count];
            int counter = 0;

            for (int i = initialArray.Length - 1; i >= 0; i--)
            {
                if (initialArray[i] % 2 == 0)
                {
                    currentArray[counter] = initialArray[i];
                    counter++;
                    if (counter == currentArray.Length)
                    {
                        break;
                    }
                }
            }

            int[] lastEvens = new int[counter];

            for (int i = 0; i < lastEvens.Length; i++)
            {
                lastEvens[i] = currentArray[i];
            }

            if (counter != 0)
            {
                Console.WriteLine($"[{string.Join(", ", lastEvens.Reverse())}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void PrintLastOdds(int[] initialArray, int count)
        {
            int[] currentArray = new int[count];
            int counter = 0;

            for (int i = initialArray.Length - 1; i >= 0; i--)
            {
                if (initialArray[i] % 2 == 1)
                {
                    currentArray[counter] = initialArray[i];
                    counter++;
                    if (counter == currentArray.Length)
                    {
                        break;
                    }
                }
            }

            int[] lastOdds = new int[counter];

            for (int i = 0; i < lastOdds.Length; i++)
            {
                lastOdds[i] = currentArray[i];
            }

            if (counter != 0)
            {
                Console.WriteLine($"[{string.Join(", ", lastOdds.Reverse())}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }
}

