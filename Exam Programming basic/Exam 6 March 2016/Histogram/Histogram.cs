using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if(number < 200)
                {
                    p1++;
                }
                else if(number >= 200 && number <= 399)
                {
                    ++p2;
                }
                else if(number >= 400 && number <= 599)
                {
                    ++p3;
                }
                else if(number >= 600 && number <= 799)
                {
                    ++p4;
                }
                else if(number >= 800)
                {
                    ++p5;
                }           
            }
            var precent1 = (double)p1 / n * 100.0;
            var precent2 = (double)p2 / n * 100.0;
            var precent3 = (double)p3 / n * 100.0;
            var precent4 = (double)p4 / n * 100.0;
            var precent5 = (double)p5 / n * 100.0;

            Console.WriteLine($"{precent1:f2}%");
            Console.WriteLine($"{precent2:f2}%");
            Console.WriteLine($"{precent3:f2}%");
            Console.WriteLine($"{precent4:f2}%");
            Console.WriteLine($"{precent5:f2}%");
        }
    }
}
