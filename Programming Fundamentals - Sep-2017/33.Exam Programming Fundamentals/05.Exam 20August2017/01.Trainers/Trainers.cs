using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Trainers
{
    class Trainers
    {
        static void Main()
        {
            var dataTeams = new Dictionary<string, double>
            {
                {"Technical", 0 },
                {"Practical", 0 },
                {"Theoretical", 0 },
            };

            var numberOfParticipants = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfParticipants; i++)
            {
                var distanceToTravelInMiles = long.Parse(Console.ReadLine()) * 1600;
                var cargo = double.Parse(Console.ReadLine()) * 1000;
                var currentParticipant = Console.ReadLine();
                double totalMoney = (cargo * 1.5) - (0.7 * distanceToTravelInMiles * 2.5);
                dataTeams[currentParticipant] += totalMoney;
            }

            var winTeam = dataTeams
                .OrderByDescending(m => m.Value)
                .First();
            Console.WriteLine($"The {winTeam.Key} Trainers win with ${winTeam.Value:f3}.");
        }
    }
}
