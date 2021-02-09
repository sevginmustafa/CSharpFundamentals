using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int convert = hours * 60 + minutes + 30;
            int hoursConvert = convert / 60;
            int minutesConvert = convert % 60;

            if (hoursConvert > 23)
            {
                hoursConvert = 0;
            }
            Console.WriteLine($"{hoursConvert}:{minutesConvert:d2}");
        }
    }
}
