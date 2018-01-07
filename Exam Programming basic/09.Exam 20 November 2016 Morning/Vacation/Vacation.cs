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
            var numberAdult = int.Parse(Console.ReadLine());
            var numberStudents = int.Parse(Console.ReadLine());
            var numberSleeps = int.Parse(Console.ReadLine());
            var typeTransport = Console.ReadLine();
            var priceStudent = 0.0;
            var priceAdult = 0.0;

            switch(typeTransport)
            {
                case "train": priceAdult = 24.99 * numberAdult;
                    priceStudent = 14.99 * numberStudents;
                    if ((numberAdult + numberStudents) >= 50)
                    {
                        priceAdult = (24.99 * 0.50) * numberAdult;
                        priceStudent = (14.99 * 0.50) * numberStudents;
                    }
                    break;
                case "bus": priceAdult = 32.50 * numberAdult;
                    priceStudent = 28.50 * numberStudents; break;
                case "boat": priceAdult = 42.99 * numberAdult;
                    priceStudent = 39.99 * numberStudents; break;
                case "airplane": priceAdult = 70.00 * numberAdult;
                    priceStudent = 50.00 * numberStudents; break;
            }

            var spendForTransport = (priceAdult + priceStudent) * 2;

            var hotelNight = 82.99 * numberSleeps;
            var commission = (spendForTransport + hotelNight) * 0.10;
            var totalSum = spendForTransport + hotelNight + commission;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
