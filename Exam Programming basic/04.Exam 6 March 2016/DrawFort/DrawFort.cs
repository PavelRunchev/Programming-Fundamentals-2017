using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            //top part
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), 
                new string('_', (2 * n) - ((2 * (n / 2)) + 4)));

            //middle part
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', (2 * n) - 2));
            }
            //bottom part
            Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1),
                new string('_', (2 * n) - ((2 * (n / 2)) + 4)));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2),
                new string(' ', (2 * n) - ((2 * (n / 2)) + 4)));
        }
    }
}
