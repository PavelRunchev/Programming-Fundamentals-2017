using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            string properties = Console.ReadLine();

            switch (properties)
            {
                case "face": CalcFace(side); break;
                case "space": CalcSpace(side); break;
                case "volume": CalcVolume(side); break;
                case "area": CalcArea(side); break;
            }
        }

        private static void CalcArea(double side)
        {
            Console.WriteLine($"{Math.Pow(side, 2) * 6:f2}");
        }

        private static void CalcVolume(double side)
        {
            Console.WriteLine($"{Math.Pow(side, 3):f2}");
        }

        private static void CalcSpace(double side)
        {
            Console.WriteLine($"{Math.Sqrt(3 * Math.Pow(side, 2)):f2}");
        }

        private static void CalcFace(double side)
        {
            Console.WriteLine($"{Math.Sqrt(2 * Math.Pow(side, 2)):f2}");
        }
    }
}
