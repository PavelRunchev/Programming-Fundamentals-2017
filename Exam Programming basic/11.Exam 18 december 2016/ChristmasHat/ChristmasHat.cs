using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            var dash = 0;
            //top part
            Console.WriteLine("{0}/|\\{0}", new string('.', 2 * n - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', 2 * n - 1));
            //middle part
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', (2 * n - 1) - point),
                    new string('-', dash));
                point++;
                dash++;
            }
            //bottom part
            Console.WriteLine($"{new string('*', 4 * n + 1)}");
            for (int i = 0; i < 1; i++)
            {
                for (int c = 0; c < 4 * n + 1; c++)
                {
                    if(c % 2 == 0)
                        Console.Write("*");
                    else
                        Console.Write(".");               
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{new string('*', 4 * n + 1)}");
        }
    }
}
