using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIn3Numbers
{
    class Program
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var min = Math.Min(Math.Min(num1, num2), num3);
            var max = Math.Max(Math.Max(num1, num2), num3);
            
            var mid = (num1 + num2 + num3) - max - min;
            var sumMin = min + mid;
            if(sumMin == max)
            {
                Console.WriteLine("{0}" + " + " + "{1}" + " = " + "{2}", min, mid, max);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
