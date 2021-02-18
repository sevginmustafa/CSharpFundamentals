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
            string[] morseCode = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            Dictionary<string, string> morseCodeDisctionary = new Dictionary<string, string>();

            morseCodeDisctionary.Add(".-", "A");
            morseCodeDisctionary.Add("-...", "B");
            morseCodeDisctionary.Add("-.-.", "C");
            morseCodeDisctionary.Add("-..", "D");
            morseCodeDisctionary.Add(".", "E");
            morseCodeDisctionary.Add("..-.", "F");
            morseCodeDisctionary.Add("--.", "G");
            morseCodeDisctionary.Add("....", "H");
            morseCodeDisctionary.Add("..", "I");
            morseCodeDisctionary.Add(".---", "J");
            morseCodeDisctionary.Add("-.-", "K");
            morseCodeDisctionary.Add(".-..", "L");
            morseCodeDisctionary.Add("--", "M");
            morseCodeDisctionary.Add("-.", "N");
            morseCodeDisctionary.Add("---", "O");
            morseCodeDisctionary.Add(".--.", "P");
            morseCodeDisctionary.Add("--.-", "Q");
            morseCodeDisctionary.Add(".-.", "R");
            morseCodeDisctionary.Add("...", "S");
            morseCodeDisctionary.Add("-", "T");
            morseCodeDisctionary.Add("..-", "U");
            morseCodeDisctionary.Add("...-", "V");
            morseCodeDisctionary.Add(".--", "W");
            morseCodeDisctionary.Add("-..-", "X");
            morseCodeDisctionary.Add("-.--", "Y");
            morseCodeDisctionary.Add("--..", "Z");

            for (int i = 0; i < morseCode.Length; i++)
            {
                if (morseCode[i] == "|")
                {
                    sb.Append(' ');
                }
                else
                {
                    sb.Append(morseCodeDisctionary[morseCode[i]]);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
