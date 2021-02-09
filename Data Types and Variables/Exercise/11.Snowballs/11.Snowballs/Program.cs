using System;
using System.Numerics;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());

            BigInteger highestSnowballValue = 0;
            string result = "";

            for (byte i = 0; i < N; i++)
            {
                ushort snowballSnow = ushort.Parse(Console.ReadLine());
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / (snowballTime), snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {highestSnowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
