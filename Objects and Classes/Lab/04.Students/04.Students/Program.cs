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
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                Student currentStudent = new Student(command[0], command[1], command[2], command[3]);
                students.Add(currentStudent);
                input = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            var studentsToBePrinted = students.FindAll(x => x.Hometown == cityName).ToList();

            foreach (var student in studentsToBePrinted)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }

        public Student(string firstName, string lastNime, string age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastNime;
            this.Age = age;
            this.Hometown = hometown;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
