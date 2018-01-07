using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReparingTheTiles
{
    class ReparingTheTiles
    {
        static void Main()
        {
            var platformLength = int.Parse(Console.ReadLine());
            var widhtTile = double.Parse(Console.ReadLine());
            var lengthTile = double.Parse(Console.ReadLine());
            var widthBench = int.Parse(Console.ReadLine());
            var lengthBench = int.Parse(Console.ReadLine());

            var surfacePlatform = platformLength * platformLength;
            var surfaceBench = widthBench * lengthBench;
            var platformArea = surfacePlatform - surfaceBench;

            var areaTiles = widhtTile * lengthTile;
            var needTiles = platformArea / areaTiles;
            var needTime = needTiles * 0.2;

            Console.WriteLine($"{needTiles:f2}");
            Console.WriteLine($"{needTime:f2}");
        }
    }
}
