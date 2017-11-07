using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            var dash = 0;
            //top part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', stars),
                    new string('-', (2 * n - 1) - dash));
                dash += 2;
                stars++;
            }
            //middle part
            stars = 0;
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i),
                    new string('*', n - stars));
                stars += 2;
            }
            //bottom part
            dash = 1;
            stars = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', dash),
                    new string('*', (2 * n - 1) - stars));
                dash++;
                stars += 2;
            }
        }
    }
}
