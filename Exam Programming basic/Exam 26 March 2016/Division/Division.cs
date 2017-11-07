using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if(number % 2 == 0)
                {
                    p1++;
                }
                if(number % 3 == 0)
                {
                    p2++;
                }
                if(number % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{(double)p1 / n * 100.0:f2}%");
            Console.WriteLine($"{(double)p2 / n * 100.0:f2}%");
            Console.WriteLine($"{(double)p3 / n * 100.0:f2}%");
        }
    }
}
