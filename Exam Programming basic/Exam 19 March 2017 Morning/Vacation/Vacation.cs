using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var price = 0.0;
            var location = string.Empty;
            var accommodation = string.Empty;
            if(budget <= 1000)
            {
                accommodation = "Camp";
                switch(season)
                {
                    case "Summer": price = budget * 0.65; location = "Alaska"; break;
                    case "Winter": price = budget * 0.45; location = "Morocco"; break;
                }
            }
            else if(budget <= 3000)
            {
                accommodation = "Hut";
                switch (season)
                {
                    case "Summer": price = budget * 0.80; location = "Alaska"; break;
                    case "Winter": price = budget * 0.60; location = "Morocco"; break;
                }
            }
            else if(budget > 3000)
            {
                accommodation = "Hotel";
                switch(season)
                {
                    case "Summer": price = budget * 0.90; location = "Alaska"; break;
                    case "Winter": price = budget * 0.90; location = "Morocco"; break;
                }
            }
            Console.WriteLine($"{location} - {accommodation} - {price:f2}");
        }
    }
}
