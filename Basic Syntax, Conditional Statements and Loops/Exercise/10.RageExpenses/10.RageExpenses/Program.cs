using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double trashedHeadset = (lostGamesCount / 2) * 1.0 * headsetPrice;
            double trashedMouse = (lostGamesCount / 3) * 1.0 * mousePrice;
            double trashedKeyboard = (lostGamesCount / 6) * 1.0 * keyboardPrice;
            double trashedDisplay = (lostGamesCount / 12) * 1.0 * displayPrice;

            double total = trashedHeadset + trashedMouse + trashedKeyboard + trashedDisplay;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
