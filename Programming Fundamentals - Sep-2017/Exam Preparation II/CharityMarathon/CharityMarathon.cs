using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main()
        {
            var lengthOfMarathonInDays = long.Parse(Console.ReadLine());
            var numberOfRunners = long.Parse(Console.ReadLine());
            var averageNumberOfLaps = long.Parse(Console.ReadLine());
            var lengthTrack = long.Parse(Console.ReadLine());
            var capacityTrack = long.Parse(Console.ReadLine());
            var amaountMoneyPerKm = decimal.Parse(Console.ReadLine());

            long maxRunners = Math.Min(lengthOfMarathonInDays * capacityTrack, numberOfRunners);

            long totalKilometers = (maxRunners * averageNumberOfLaps * lengthTrack) / 1000;
            decimal moneyMarathon = totalKilometers * amaountMoneyPerKm;
            Console.WriteLine($"Money raised: {moneyMarathon:f2}");

        }
    }
}
