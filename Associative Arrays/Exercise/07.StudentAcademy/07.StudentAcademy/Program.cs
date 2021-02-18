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

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName].Add(grade);
                }
                else
                {
                    studentGrades.Add(studentName, new List<double>());
                    studentGrades[studentName].Add(grade);
                }
            }

            foreach (var student in studentGrades.OrderByDescending(x => x.Value.Average()))
            {
                double averageGrade = student.Value.Average(x => x);

                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
