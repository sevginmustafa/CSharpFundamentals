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
            Dictionary<string, int> items = new Dictionary<string, int>();

            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);

            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();

            while (items["shards"] < 250 && items["fragments"] < 250 && items["motes"] < 250)
            {
                string[] array = Console.ReadLine().ToLower().Split().ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (items["shards"] >= 250 || items["fragments"] >= 250 || items["motes"] >= 250)
                        {
                            break;
                        }

                        if (items.ContainsKey(array[i]))
                        {
                            items[array[i]] += int.Parse(array[i - 1]);
                        }
                        else
                        {
                            if (junkItems.ContainsKey(array[i]))
                            {
                                junkItems[array[i]] += int.Parse(array[i - 1]);
                            }
                            else
                            {
                                junkItems.Add(array[i], int.Parse(array[i - 1]));
                            }
                        }
                    }
                }
            }

            if (items["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                items["shards"] -= 250;
            }
            else if (items["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                items["fragments"] -= 250;
            }
            else if (items["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                items["motes"] -= 250;
            }

            foreach (var pair in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            foreach (var pair in junkItems)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }
    }
}
