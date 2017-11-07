using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldRecordOfSwimming
{
    class WorldRecordOfSwimming
    {
        static void Main()
        {
            var worldRecordInSeconds = double.Parse(Console.ReadLine());
            var distanceInMetres = double.Parse(Console.ReadLine());
            var timeInSecondsForOneMetre = double.Parse(Console.ReadLine());

            var needSwimming = distanceInMetres * timeInSecondsForOneMetre;
            var timeInSeconds = Math.Floor(distanceInMetres / 15.0) * 12.5;
            var allTimeInSeconds = needSwimming + timeInSeconds;

            var notEnoughSeconds = allTimeInSeconds - worldRecordInSeconds;
            Console.WriteLine(allTimeInSeconds < worldRecordInSeconds ?
                $"Yes, he succeeded! The new world record is {allTimeInSeconds:f2} seconds." :
                $"No, he failed! He was {notEnoughSeconds:f2} seconds slower.");
        }
    }
}
