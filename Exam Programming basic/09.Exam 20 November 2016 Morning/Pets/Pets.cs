using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main()
        {
            var numberDays = int.Parse(Console.ReadLine());
            var leftFoodKgs = int.Parse(Console.ReadLine());
            var foodsForDogKg = double.Parse(Console.ReadLine());
            var foodsForCatKg = double.Parse(Console.ReadLine());
            var foodsForTurtleGram = double.Parse(Console.ReadLine());

            var needFoodDogKg = numberDays * foodsForDogKg;
            var needFoodCatKg = numberDays * foodsForCatKg;
            var needFoodTurtleKg = (foodsForTurtleGram / 1000) * numberDays;
            var allFood = needFoodDogKg + needFoodCatKg + needFoodTurtleKg;

            Console.WriteLine(allFood <= leftFoodKgs ? 
                $"{Math.Floor(leftFoodKgs - allFood)} kilos of food left." 
                : $"{Math.Ceiling(allFood - leftFoodKgs)} more kilos of food are needed.");
        }
    }
}
