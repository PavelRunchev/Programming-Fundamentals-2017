using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class LongerLine
    {
        static void Main()
        {
            Line line1 = ReadLine();
            Line line2 = ReadLine();
            if(line1.Length >= line2.Length)
            {
                Console.WriteLine($"({line1.CloserPoint.X}, {line1.CloserPoint.Y})({line1.LongestPoint.X}, {line1.LongestPoint.Y})");
            }
            else
            {
                Console.WriteLine($"({line2.CloserPoint.X}, {line2.CloserPoint.Y})({line2.LongestPoint.X}, {line2.LongestPoint.Y})");
            }
        }

        private static Line ReadLine()
        {
            Point closerPoint = new Point();
            Point longestPoint = new Point();
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double lengthLine = GetLengthLine(x1, y1, x2, y2);
            
            Point point1 = GetCloserPoint(x1, y1);
            point1.X = x1;
            point1.Y = y1;
            Point point2 = GetCloserPoint(x2, y2);
            point2.X = x2;
            point2.Y = y2;
            if(point1.LengthP <= point2.LengthP)
            {
                closerPoint = point1;
                longestPoint = point2;
            }
            else
            {
                closerPoint = point2;
                longestPoint = point1;
            }
                    
            return new Line
            {
                Length = lengthLine,
                CloserPoint = closerPoint,
                LongestPoint = longestPoint
            };
        }

        private static Point GetCloserPoint(double x, double y)
        {
            Point point = new Point();
            double distance = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
            point.LengthP = distance;
            return point;
        }

        private static double GetLengthLine(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double LengthP { get; set; }
    }

    class Line
    {
        public double Length { get; set; }
        public Point CloserPoint { get; set; }
        public Point LongestPoint { get; set; }
    }
}
