using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sumLetterIndex = "";

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                char mainDigit = current[0];
                int convertMainDigit = int.Parse(mainDigit.ToString());
                int offset = (convertMainDigit - 2) * 3;
                if (convertMainDigit == 8 || convertMainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = (offset + current.Length - 1) + 97;
                if (convertMainDigit == 0)
                {
                    letterIndex = 32;
                }
                char convertLetterIndex = (char)letterIndex;
                sumLetterIndex += convertLetterIndex;
            }
            Console.WriteLine(sumLetterIndex);
        }
    }
}
