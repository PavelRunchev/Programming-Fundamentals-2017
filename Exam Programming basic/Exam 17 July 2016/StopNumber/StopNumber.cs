using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                
                if(i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stopNumber)
                        break;
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
