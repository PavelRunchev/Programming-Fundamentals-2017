using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            var space = 0;
            //top part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', (((3 * n) / 2) - 1) - point),
                    new string(' ', space));
                point++;
                space += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', space));
            //middle part
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), 
                    new string('\\', 2 * n - 2));
            }

            //bottom part
            point = 0;
            var stars = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', n / 2 - point),
                    new string('*', (2 * n - 2) + stars));
                point++;
                stars += 2;
            }
        }
    }
}
