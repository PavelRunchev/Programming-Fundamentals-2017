using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //upper part
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
            }
            // middle part
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
            // bottom part
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
            }
        }
    }
}
