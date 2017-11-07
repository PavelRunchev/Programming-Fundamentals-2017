using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', 2 * n + 1));

            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', point), 
                    new string('~', n - 2), new string('.', (2 * n) - point));
                point++;
            }
            point = 0;
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', point),
                    new string('.', (2 * n) - point), new string('~', n - 2));
                point++;
            }

            Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1), 
                new string('~', n - 2));
        }
    }
}
