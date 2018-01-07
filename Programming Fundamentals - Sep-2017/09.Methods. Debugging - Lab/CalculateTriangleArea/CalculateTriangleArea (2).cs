using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Triangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static double Area(Triangle triangle)
        {
            return triangle.Width * triangle.Height / 2;
        }
    }
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(width, height);
            Console.WriteLine(Triangle.Area(triangle));
        }
    }
}
