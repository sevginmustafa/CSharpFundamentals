using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThreeNumbers(one, two, three));
        }

        static int SmallestOfThreeNumbers(int one, int two, int three)
        {
            int minNum = Math.Min(Math.Min(one, two), three);
            return minNum;
        }
    }
}
