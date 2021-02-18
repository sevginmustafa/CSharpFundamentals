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
            string input = string.Empty;

            List<Dwarf> dwarfs = new List<Dwarf>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] splittedInput = input.Split(" <:> ");

                string dwarfName = splittedInput[0];
                string dwarfHatColor = splittedInput[1];
                int dwarfPhysics = int.Parse(splittedInput[2]);

                Dwarf check = dwarfs.Find(x => x.Name == dwarfName && x.Color == dwarfHatColor);

                if (check == null)
                {
                    Dwarf dwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
                    dwarfs.Add(dwarf);
                }
                else
                {
                    if (check.Physics < dwarfPhysics)
                    {
                        check.Physics = dwarfPhysics;
                    }
                }
            }

            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x => dwarfs.Count(y => y.Color == x.Color)))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        public class Dwarf
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Physics { get; set; }

            public Dwarf(string name, string color, int physics)
            {
                this.Name = name;
                this.Color = color;
                this.Physics = physics;
            }
        }
    }
}
