using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Resurrection
{
    class Resurrection
    {
        static void Main()
        {
            int amountOfPhoenix = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfPhoenix; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());
                
                decimal totalYear = (decimal)Math.Pow(totalLength, 2) * (totalWidth + 2 * wingLength);
                BigInteger year = 0;
                if (BigInteger.TryParse(totalYear.ToString(), out year))
                {
                    Console.WriteLine($"{year}");
                }
                else
                {
                    Console.WriteLine($"{totalYear}");
                }
            }
        }
    }
}
