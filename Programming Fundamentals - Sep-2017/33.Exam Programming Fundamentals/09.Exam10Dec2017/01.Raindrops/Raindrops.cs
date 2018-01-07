using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Raindrops
{
    class Raindrops
    {
        static void Main()
        {
            int countOfRegion = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double sumAllRegionCoefficient = 0;
            for (int i = 0; i < countOfRegion; i++)
            {
                string[] input = Console.ReadLine().Split();
                long raindropsCount = long.Parse(input[0]);
                int squareMeters = int.Parse(input[1]);
                double coefficient = raindropsCount / (double)squareMeters;
                sumAllRegionCoefficient += coefficient;
            }

            double result = density != 0 ? sumAllRegionCoefficient / density : sumAllRegionCoefficient;
            Console.WriteLine($"{result:f3}");
        }
    }
}
