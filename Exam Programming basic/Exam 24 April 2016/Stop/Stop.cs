using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Stop
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            var dash = 0;

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n - point), 
                    new string('_', (2 * n - 1) + dash));
                point++;
                dash += 2; 
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', ((4 * n + 3) - 9) / 2));

            point = 0;
            dash = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', point), 
                    new string('_', ((4 * n + 3) - 4) - dash));
                point++;
                dash += 2;
            }

            Console.WriteLine("{0}\\\\{1}//{0}", new string('.', n - 1), new string('_', 2 * n +1));
        }
    }
}
