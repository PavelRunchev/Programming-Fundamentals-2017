using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOrWork
{
    class Program
    {
        static void Main()
        {
            var controlNumber = int.Parse(Console.ReadLine());
            bool noNumber = true;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if(a + b + c == controlNumber && (a < b && b < c))
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {controlNumber}");
                            noNumber = false;
                        }
                        if((a > b && b > c) && (a * b * c) == controlNumber)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {controlNumber}");
                            noNumber = false;
                        }
                    }
                }
            }
            if (noNumber)
            {
                Console.WriteLine($"No!");
            }

        }
    }
}
