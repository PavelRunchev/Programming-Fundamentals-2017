using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dash = 0;
            var dies = 0;
            var width = 12 * n - 5;
            //top part
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width / 2) - dash),
                    new string('#', 1 + dies));
                dash += 3;
                dies += 6;
            }
            dash = 0;
            dies = 0;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + dash), 
                    new string('#', (width - 6) - dies), new string('.', 3 + dash));
                dash += 3;
                dies += 6;
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', (width - 6 * n + 1) / 2 - 2), 
                    new string('#', 6 * n + 1), new string('.', (width - 6 * n + 1) / 2 - 1));
            }

            Console.WriteLine("@{0}{1}{2}", new string('.', (width - 6 * n + 1) / 2 - 2),
                    new string('#', 6 * n + 1), new string('.', (width - 6 * n + 1) / 2 - 1));
        }
    }
}
