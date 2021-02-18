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
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] data = input.Split();

                Person person = new Person(data[0], data[1], int.Parse(data[2]));
                people.Add(person);
                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.".ToString();
            }
        }
    }
}
