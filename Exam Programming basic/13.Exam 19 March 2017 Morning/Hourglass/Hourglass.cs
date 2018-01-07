using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Hourglass
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            var at = 0;
            //top part
            Console.WriteLine($"{new string('*', 2 * n + 1)}");
            Console.WriteLine($".*{new string(' ', 2 * n - 3)}*.");
            
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', 2 + point),
                    new string('@', ((2 * n + 1) - 6) - at));
                point++;
                at += 2;
            }
            //middle part
            Console.WriteLine("{0}*{0}", new string('.', n));
            point = 0;
            var space = 0;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', (n - 1) - point),
                    new string(' ', space));
                point++;
                space++;
            }
            //bottom part
            Console.WriteLine($".*{new string('@', (2 * n + 1) - 4)}*.");
            Console.WriteLine($"{new string('*', 2 * n + 1)}");
        }
    }
}
