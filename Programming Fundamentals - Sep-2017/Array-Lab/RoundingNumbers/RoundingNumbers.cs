using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                double num = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {num}");
            }
        }
    }
}
