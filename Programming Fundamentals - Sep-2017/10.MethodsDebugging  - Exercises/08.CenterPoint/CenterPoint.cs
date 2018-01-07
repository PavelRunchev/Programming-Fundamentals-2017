using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPodouble
{
    class CenterPodouble
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double podouble1 = Distance(x1, y1);
            double podouble2 = Distance(x2, y2);
           
            Console.WriteLine(podouble1 <= podouble2 ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }

        private static double Distance(double x1, double y1)
        {
            return (double)Math.Sqrt(Math.Pow(x1 - 0, 2) + Math.Pow(y1 - 0, 2));
        }
    }
}
