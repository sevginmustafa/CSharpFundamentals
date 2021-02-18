using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            Console.WriteLine(AddandSubtract(one, two, three));
        }

        static int AddandSubtract(int one, int two, int three)
        {
            return one + two - three;
        }
    }
}
