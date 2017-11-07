using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main()
        {
            var numberCargo = int.Parse(Console.ReadLine());
            var miniBus = 0;
            var truck = 0;
            var train = 0;
            var countCargo = 0;
            for (int i = 0; i < numberCargo; i++)
            {
                var cargo = int.Parse(Console.ReadLine());

                if(cargo <= 3)
                    miniBus += cargo;
                else if(cargo <= 11)
                    truck += cargo;
                else if(cargo >= 12)
                    train += cargo;
                countCargo += cargo;
            }
            var priceForTonnage = (miniBus * 200) + (truck * 175) + (train * 120);

            var averagePeTonne = (double)priceForTonnage / countCargo;
            var precentMiniBus = (double)miniBus / countCargo * 100.0;
            var precentTruck = (double)truck / countCargo * 100.0;
            var precentTrain = (double)train / countCargo * 100.0;

            Console.WriteLine($"{averagePeTonne:f2}");
            Console.WriteLine($"{precentMiniBus:f2}%");
            Console.WriteLine($"{precentTruck:f2}%");
            Console.WriteLine($"{precentTrain:f2}%");
        }
    }
}
