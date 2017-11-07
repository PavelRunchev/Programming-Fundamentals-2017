using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{new string('#', 4 * n + 1)}");
            //upper part
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", new string('.', 1 + i));
                Console.Write("{0}", new string('#', (2 * n - 1) - 2 * i));

                if(i == n / 2)
                    Console.Write("{0}(@){0}", new string(' ', (2 * n) / 4 - 1));
                else
                    Console.Write("{0}", new string(' ', 1 + 2 * i));

                Console.Write("{0}", new string('#', (2 * n - 1) - 2 * i));
                Console.WriteLine("{0}", new string('.', 1 + i));
            }
           
            //bottom part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (n + 1) + i),
                    new string('#', (2 * n - 1) - 2 * i));
            }
        }
    }
}
