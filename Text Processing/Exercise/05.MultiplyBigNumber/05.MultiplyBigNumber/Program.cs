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
            BigInteger bigNum = BigInteger.Parse(Console.ReadLine());
            byte smallNum = byte.Parse(Console.ReadLine());

            Console.WriteLine(bigNum * smallNum);
        }
    }
}
