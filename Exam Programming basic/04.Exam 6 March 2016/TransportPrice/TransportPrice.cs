using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main()
        {
            var numberKilometers = int.Parse(Console.ReadLine());
            var days = Console.ReadLine();
            var price = 0.0;

            switch(days)
            {
                case "day":
                    if (numberKilometers < 20)
                        price = 0.70 + 0.79 * numberKilometers; break;
                case "night":
                    if (numberKilometers < 20)
                        price = 0.70 + 0.90 * numberKilometers; break;
            }
            if (numberKilometers >= 20 && numberKilometers < 100)
                price = 0.09 * numberKilometers;
            else if (numberKilometers >= 100)
                price = 0.06 * numberKilometers;
            Console.WriteLine(price);
        }
    }
}
