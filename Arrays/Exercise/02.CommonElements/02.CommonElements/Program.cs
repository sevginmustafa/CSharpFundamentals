using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            string output = "";

            for (int i = 0; i < secondArray.Length; i++)
            {
                string checkSecondArray = secondArray[i];

                for (int j = 0; j < firstArray.Length; j++)
                {
                    string checkFirstArray = firstArray[j];

                    if (checkFirstArray == checkSecondArray)
                    {
                        output += checkFirstArray + " ";
                    }
                }
            }
            Console.WriteLine(output + "");
        }
    }
}
