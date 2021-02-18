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
            int n = int.Parse(Console.ReadLine());
            Message message = new Message();
            message.Randomizer(n);
        }
    }

    public class Message
    {
        public string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        public string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        public string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        public string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public void Randomizer(int n)
        {
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                string phrase = Phrases[rand.Next(0, Phrases.Length - 1)];
                string events = Events[rand.Next(0, Events.Length - 1)];
                string author = Authors[rand.Next(0, Authors.Length - 1)];
                string city = Cities[rand.Next(0, Cities.Length - 1)];

                string randomPhrase = $"{ phrase } { events} { author} - { city}";
                Console.WriteLine(randomPhrase);
            }
        }
    }
}
