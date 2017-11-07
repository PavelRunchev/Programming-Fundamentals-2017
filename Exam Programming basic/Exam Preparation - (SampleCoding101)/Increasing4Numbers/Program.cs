using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if(b - a < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = a; n1 <= b; n1++)
                {
                    for (int n2 = a; n2 <= b; n2++)
                    {
                        for (int n3 = a; n3 <= b; n3++)
                        {
                            for (int n4 = a; n4 <= b; n4++)
                            {
                                if(a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 <= b)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4}");
                                }                               
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
