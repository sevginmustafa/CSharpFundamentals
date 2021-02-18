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

            Dictionary<string, SortedDictionary<string, List<double>>> dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();

            for (int i = 0; i < n; i++)
            {
                int damage = 45;
                int health = 250;
                int armor = 10;

                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];

                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, List<double>>());
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new List<double>());
                }
                dragons[type][name] = new List<double>() { damage, health, armor };
            }

            foreach (var dragon in dragons)
            {
                double averageDamage = dragon.Value.Select(x => x.Value[0]).Average();
                double averageHealth = dragon.Value.Select(x => x.Value[1]).Average();
                double averageArmor = dragon.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in dragon.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
