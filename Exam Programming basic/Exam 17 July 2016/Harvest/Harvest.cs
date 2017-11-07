using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main()
        {
            var vineyard = int.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var needWine = int.Parse(Console.ReadLine());
            var numberWorkers = int.Parse(Console.ReadLine());

            var allGrapes = vineyard * grape;
            var litersWine = (allGrapes * 0.40) / 2.5;
            if(litersWine >= needWine)
            {
                var leftLitersWine = Math.Ceiling(litersWine - needWine);
                var vineForOneWorker = Math.Ceiling(leftLitersWine / numberWorkers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{leftLitersWine} liters left -> {vineForOneWorker} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needWine - litersWine)} liters wine needed.");
            }
        }
    }
}
