using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string geometryFigure = Console.ReadLine();
            switch (geometryFigure)
            {
                case "triangle": CalcTriangleArea(); break;
                case "square": CalcSquareArea(); break;
                case "rectangle": CalcRectangleArea(); break;
                case "circle": CalcCircleArea(); break;
            }
        }

        private static void CalcCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * Math.Pow(radius, 2):f2}");
        }

        private static void CalcRectangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width * height:f2}");
        }

        private static void CalcSquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side * side:f2}");
        }

        private static void CalcTriangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width * height / 2:f2}");
        }
    }
}
