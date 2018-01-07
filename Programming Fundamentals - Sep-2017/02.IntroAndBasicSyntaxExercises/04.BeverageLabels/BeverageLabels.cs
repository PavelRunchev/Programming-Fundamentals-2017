using System;
using System.Text;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            var kcal = volume * energy / 100.0;
            var g = volume * sugar / 100.0;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {g}g sugars");
        }
    }
}
