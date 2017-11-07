using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var widhtFloor = double.Parse(Console.ReadLine());
            var lengthFloor = double.Parse(Console.ReadLine());
            var sideOfTriangle = double.Parse(Console.ReadLine());
            var heigthOfTriangle = double.Parse(Console.ReadLine());
            var PriceTile = double.Parse(Console.ReadLine());
            var sumForWorker = double.Parse(Console.ReadLine());

            var areaFloor = widhtFloor * lengthFloor;
            var areaTile = sideOfTriangle * heigthOfTriangle / 2.0;
            var needTiles = Math.Ceiling(areaFloor / areaTile) + 5;

            var totalSum = (needTiles * PriceTile) + sumForWorker;
            var left = Math.Abs(totalSum - money);
            Console.WriteLine(money >= totalSum ? $"{left:f2} lv left." : $"You'll need {left:f2} lv more.");
        }
    }
}
