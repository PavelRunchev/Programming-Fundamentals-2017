using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class Program
    {
        static void Main()
        {
            var M = int.Parse(Console.ReadLine());
            var N = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());
            var specialNumber = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            for (int i1 = M; i1 >= 1; i1--)
            {
                for (int i2 = N; i2 >= 1; i2--)
                {
                    for (int i3 = L; i3 >= 1; i3--)
                    {
                        var num = (i1 * 100) + (i2 * 10) + i3;
                        if(num % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if(num % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if(num % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if(specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }
    }
}
