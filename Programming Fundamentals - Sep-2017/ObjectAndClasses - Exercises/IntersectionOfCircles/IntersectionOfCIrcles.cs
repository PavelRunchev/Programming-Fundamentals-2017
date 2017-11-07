using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public static bool Intersect(Circle c1, Circle c2, double distance)
        {
            if(distance > c1.Radius + c2.Radius)
            {
                return false;
            }
            return true;
        }
    }
    class IntersectionOfCIrcles
    {
        static void Main()
        {
            Circle c1 = ReadCircle();
            Circle c2 = ReadCircle();

            double distance = CalcDistance(c1.Center, c2.Center);

            Console.WriteLine(Circle.Intersect(c1, c2, distance) ? "Yes" : "No");
        }

        private static double CalcDistance(Point center1, Point center2)
        {
            return Math.Sqrt(Math.Pow(center2.X - center1.X, 2) + Math.Pow(center2.Y - center1.Y, 2));
        }

        private static Circle ReadCircle()
        {
            double[] input = Console.ReadLine()
                .Split(' ').Select(double.Parse)
                .ToArray();
            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            return new Circle
            {
                Center = point,
                Radius = input[2]
            };
        }
    }
}
