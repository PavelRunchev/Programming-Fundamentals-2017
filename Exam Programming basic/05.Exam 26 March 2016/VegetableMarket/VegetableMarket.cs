using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main()
        {
            var vegetablePriceKg = double.Parse(Console.ReadLine());
            var fruitPriceKg = double.Parse(Console.ReadLine());
            var allvegetableKg = int.Parse(Console.ReadLine());
            var allfruitKg = int.Parse(Console.ReadLine());

            var vegetablePrice = vegetablePriceKg * allvegetableKg;
            var fruitPrice = fruitPriceKg * allfruitKg;
            var totalPriceEuro = (vegetablePrice + fruitPrice) / 1.94;
            Console.WriteLine(totalPriceEuro);
        }
    }
}
