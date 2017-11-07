using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main()
        {
            var vineyard = double.Parse(Console.ReadLine());
            var grapesKgForSquareMetre = double.Parse(Console.ReadLine());
            var marriage = double.Parse(Console.ReadLine());

            var grapesKg = vineyard * grapesKgForSquareMetre - marriage;
            var grapesForRakia = grapesKg * 0.45;
            var litreRakia = grapesForRakia / 7.5;
            var incomeRakia = litreRakia * 9.80;


            var incomeGrapes = (grapesKg * 0.55) * 1.50;

            Console.WriteLine($"{incomeRakia:f2}\n{incomeGrapes:f2}");
        }
    }
}
