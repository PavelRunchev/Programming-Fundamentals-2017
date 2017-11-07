using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    class ClosestTwoPoints
    {
        static void Main()
        {
            var points = new List<Point>();
            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                double[] input = Console.ReadLine().Split()
                    .Select(double.Parse).ToArray();
                double x = input[0];
                double y = input[1];
                Point p = new Point(x, y);
                points.Add(p);
            }

            FindClosestPoints(points);

        }

        private static void FindClosestPoints(List<Point> points)
        {
            Point[] ClosestTwoPairsPoints = new Point[2];
            double minDistance = double.MaxValue; ;
            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first +1; second < points.Count; second++)
                {
                    double distance = CalcDistance(points[first], points[second]);
                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        ClosestTwoPairsPoints[0] = points[first];
                        ClosestTwoPairsPoints[1] = points[second];
                    }
                }
            }

            PrintClosestTwoPoints(ClosestTwoPairsPoints, minDistance);
        }

        private static void PrintClosestTwoPoints(Point[] closestTwoPairsPoints, double minDistance)
        {
            Console.WriteLine($"{minDistance:f3}");
            foreach (var point in closestTwoPairsPoints)
            {
                Console.WriteLine($"{point}");
            }
        }

        private static double CalcDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}
