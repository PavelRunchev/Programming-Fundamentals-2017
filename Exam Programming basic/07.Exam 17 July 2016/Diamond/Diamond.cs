using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            var middlePoint = 0;
            //top part
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            for (int i = 0; i < n -1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (n - 1) - point), 
                    new string('.', (3 * n) + middlePoint));
                point++;
                middlePoint += 2;
            }
            point = 0;
            middlePoint = 0;
            //middle part
            Console.WriteLine($"{new string('*', 5 * n)}");

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', 1 + point), 
                    new string('.', (5 * n - 4) - middlePoint));
                point++;
                middlePoint += 2;
            }
            //bottom part
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), 
                new string('*', n - 2));
        }
    }
}
