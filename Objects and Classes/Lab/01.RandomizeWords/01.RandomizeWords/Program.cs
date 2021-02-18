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
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.words = Console.ReadLine().Split();
            randomizer.Randomize();
            randomizer.PrintWords();
        }
    }

    public class StringRandomizer
    {
        public string[] words;

        public void Randomize()
        {
            Random rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomPosition = rand.Next(0, this.words.Length);
                string temp = this.words[i];
                this.words[i] = this.words[randomPosition];
                this.words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.words));
        }
    }
}
