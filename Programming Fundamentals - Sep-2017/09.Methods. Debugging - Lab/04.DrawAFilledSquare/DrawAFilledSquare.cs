using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            PrintHeaderDraw(num);
            for (int i = 0; i < num - 2; i++)
            {
                PrintMiddleRow(num);
            }
            
            PrintHeaderDraw(num);
        }

        private static void PrintMiddleRow(int num)
        {
            Console.Write("-");
            for (int i = 1; i < num; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void PrintHeaderDraw(int num)
        {
            Console.WriteLine("{0}", new string('-', 2 * num));
        }
    }
}
