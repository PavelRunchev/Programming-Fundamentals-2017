using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main()
        {
            var season = Console.ReadLine();
            var kmForMonth = double.Parse(Console.ReadLine());
            var price = 0.0;
            if(kmForMonth <= 5000)
            {
                switch(season)
                {
                    case "Spring":
                    case "Autumn": price = 0.75; break;
                    case "Summer": price = 0.90; break;
                    case "Winter": price = 1.05; break;
                }
            }
            else if(kmForMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": price = 0.95; break;
                    case "Summer": price = 1.10; break;
                    case "Winter": price = 1.25; break;
                }
            }
            else if(kmForMonth <= 20000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": 
                    case "Summer": 
                    case "Winter": price = 1.45; break;
                }
            }
            var salary = ((kmForMonth * price) * 4) * 0.90;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
