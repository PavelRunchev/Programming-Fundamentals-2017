using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Crown
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0;
            var space = 0;
            var width = 2 * n - 1;
            //top part
            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));
            //middle part
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', 1 + point),
                    new string(' ', ((width - 9) / 2) - space), new string('.', 1 + 2 * i));
                point++;
                space += 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n / 2 - 1)),
                new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), 
                new string('*', n / 2 - 2));
            //bottom part
            Console.WriteLine($"{new string('*', (2 * n) - 1)}");
            Console.WriteLine($"{new string('*', (2 * n) - 1)}");
        }
    }
}
