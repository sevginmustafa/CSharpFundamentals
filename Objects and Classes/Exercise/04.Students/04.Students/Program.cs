using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentStudent = Console.ReadLine().Split().ToArray();
                Student student = new Student(currentStudent[0], currentStudent[1], double.Parse(currentStudent[2]));
                students.Add(student);
            }

            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(i => i.Grade)));
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string secondName, double grade)
            {
                this.FirstName = firstName;
                this.SecondName = secondName;
                this.Grade = grade;
            }

            public override string ToString()
            {
                return $"{FirstName} {SecondName}: {Grade:f2}";
            }
        }
    }
}
