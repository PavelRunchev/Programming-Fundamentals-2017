using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var trip = string.Empty;
            var sum = 0.0;
            var typeTrip = string.Empty;
            if(budget <= 100)
            {
                switch(season)
                {
                    case "summer": typeTrip = "Bulgaria"; trip = "Camp"; sum = budget * 0.3; break;
                    case "winter": typeTrip = "Bulgaria"; trip = "Hotel"; sum = budget * 0.7; break;
                }
            }
            else if(budget > 100 && budget <= 1000)
            {
                switch (season)
                {
                    case "summer": typeTrip = "Balkans"; trip = "Camp"; sum = budget * 0.4; break;
                    case "winter": typeTrip = "Balkans"; trip = "Hotel"; sum = budget * 0.8; break;
                }
            }
            else if(budget > 1000)
            {
                switch (season)
                {
                    case "summer": typeTrip = "Europe"; trip = "Hotel"; sum = budget * 0.9; break;
                    case "winter": typeTrip = "Europe"; trip = "Hotel"; sum = budget * 0.9; break;
                }
            }
            Console.WriteLine($"Somewhere in {typeTrip}");
            Console.WriteLine($"{trip} - {sum:f2}");
        }
    }
}
