using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    class CarToGo
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var price = 0.0;
            var classCar = string.Empty;
            var typeCar = string.Empty;
            if(budget <= 100)
            {
                classCar = "Economy class";
                switch(season)
                {
                    case "Summer": price = budget * 0.35; typeCar = "Cabrio"; break;
                    case "Winter": price = budget * 0.65; typeCar = "Jeep"; break;
                }
            }
            else if(budget <= 500)
            {
                classCar = "Compact class";
                switch(season)
                {
                    case "Summer": price = budget * 0.45; typeCar = "Cabrio"; break;
                    case "Winter": price = budget * 0.80; typeCar = "Jeep"; break;
                }
            }
            else if(budget > 500)
            {
                classCar = "Luxury class";
                switch (season)
                {
                    case "Summer": 
                    case "Winter": price = budget * 0.90; typeCar = "Jeep"; break;
                }
            }
            Console.WriteLine($"{classCar}");
            Console.WriteLine($"{typeCar} - {price:f2}");
        }
    }
}
