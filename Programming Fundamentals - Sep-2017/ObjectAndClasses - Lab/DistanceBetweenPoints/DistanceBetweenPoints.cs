using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = CalcDistance(p1, p2);
            Console.WriteLine($"{distance:f3}");
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        private static Point ReadPoint()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double x = input[0];
            double y = input[1];
            return new Point(x, y);
        }
    }
}
