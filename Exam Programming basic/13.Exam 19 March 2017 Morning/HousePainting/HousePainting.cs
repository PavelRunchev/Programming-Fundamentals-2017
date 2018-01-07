using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class HousePainting
    {
        static void Main()
        {
            var heightInHouse = double.Parse(Console.ReadLine());
            var lengthInHouse = double.Parse(Console.ReadLine());
            var heightInRoof = double.Parse(Console.ReadLine());

            var sidesInHouse = ((heightInHouse * lengthInHouse) - (1.5 * 1.5)) * 2.0;
            var frontSide = (heightInHouse * heightInHouse) - (1.2 * 2);
            var backSide = heightInHouse * heightInHouse;
            var greenPaint = (sidesInHouse + frontSide + backSide) / 3.4;

            var roofArea = ((heightInHouse * lengthInHouse) * 2.0) + ((heightInHouse * heightInRoof / 2.0) * 2.0);
            var redPaint = roofArea / 4.3;
            Console.WriteLine($"{greenPaint:f2}\n{redPaint:f2}");
        }
    }
}
