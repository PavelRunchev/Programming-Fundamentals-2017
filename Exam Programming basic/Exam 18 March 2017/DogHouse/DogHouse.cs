using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class DogHouse
    {
        static void Main()
        {
            var lengthOfSide = double.Parse(Console.ReadLine());
            var heightOfHouse = double.Parse(Console.ReadLine());

            var roofArea = (lengthOfSide * (lengthOfSide / 2)) * 2.0;
            var needRedPaint = roofArea / 5.0;

            var sidesArea = 2 * (lengthOfSide * lengthOfSide / 2.0);
            var backWall = ((lengthOfSide / 2.0) * (lengthOfSide / 2.0)) +
                ((lengthOfSide / 2) * (heightOfHouse - lengthOfSide / 2.0) / 2.0);

            var enter = (lengthOfSide / 5.0) * (lengthOfSide / 5.0);
            var frontWall = backWall - enter;
            var needGreenPaint = (frontWall + sidesArea + backWall) / 3.0; 

            Console.WriteLine($"{needGreenPaint:f2}");
            Console.WriteLine($"{needRedPaint:f2}");
        }
    }
}
