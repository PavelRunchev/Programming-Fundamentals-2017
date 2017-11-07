using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dash = 0;
           
            //top part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), 
                    new string('-', dash), new string('-', (2 * n - 2) - dash));
                dash++;
            }
            //middle part
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', 3 * n), 
                    new string('-', n - 1));
            }
            dash = 0;
            var middleDash = 0;
            //bottom part
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - dash), 
                    new string('-', (n - 1) + middleDash), new string('-', (n - 1) - dash));
                dash++;
                middleDash += 2;
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - dash), 
                new string('*', (n - 1) + middleDash), new string('-', (n - 1) - dash));
        }
    }
}
