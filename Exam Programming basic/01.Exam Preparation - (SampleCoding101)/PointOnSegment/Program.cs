using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            var left = Math.Min(first, second);
            var right = Math.Max(first, second);
            var leftDist = Math.Abs(point - left);
            var rightDist = Math.Abs(point - right);
            var distance = Math.Min(leftDist, rightDist);

            if (point >= left && point <= right)
            {
                Console.WriteLine("in");            
            }
            else
            {
                    Console.WriteLine("out");
            }           
            Console.WriteLine($"{distance}");
        }
    }
}
