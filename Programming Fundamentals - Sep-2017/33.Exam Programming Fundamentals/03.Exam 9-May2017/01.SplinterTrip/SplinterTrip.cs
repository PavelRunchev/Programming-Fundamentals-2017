using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    class SplinterTrip
    {
        static void Main()
        {
            var distanceInMiles = double.Parse(Console.ReadLine());
            var fuelCapacity = double.Parse(Console.ReadLine());
            var spentInHeavyWinds = double.Parse(Console.ReadLine());
            var nonWindsConsumptionLiters = (distanceInMiles - spentInHeavyWinds) * 25;
            var windsConsumptionLeters = spentInHeavyWinds * (25 * 1.5);
            var fuelConsumption = nonWindsConsumptionLiters + windsConsumptionLeters;
            var tolerance = fuelConsumption * 0.05;
            var totalFuel = fuelConsumption + tolerance;

            Console.WriteLine($"Fuel needed: {totalFuel:f2}L");
            var remainingFuel = fuelCapacity - totalFuel;
            Console.WriteLine(remainingFuel >= 0 
                ? $"Enough with {remainingFuel:f2}L to spare!" 
                : $"We need {Math.Abs(remainingFuel):f2}L more fuel.");
        }
    }
}
