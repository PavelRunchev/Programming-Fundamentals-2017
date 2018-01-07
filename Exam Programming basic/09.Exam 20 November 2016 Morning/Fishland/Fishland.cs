using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main()
        {
            var priceMackerelForKg = double.Parse(Console.ReadLine());
            var priceSpratForKg = double.Parse(Console.ReadLine());
            var palmwoodKg = double.Parse(Console.ReadLine());
            var horseMeckerelKg = double.Parse(Console.ReadLine());
            var clamKg = int.Parse(Console.ReadLine());

            var sumClam = clamKg * 7.50;
            var sumPalmwood = (priceMackerelForKg + (priceMackerelForKg * 0.60)) * palmwoodKg;
            var sumHorseMeckerel = (priceSpratForKg +(priceSpratForKg * 0.80)) * horseMeckerelKg;

            var totalSum = sumClam + sumPalmwood + sumHorseMeckerel;
            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
