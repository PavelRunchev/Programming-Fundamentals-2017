using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main()
        {
            var startSpace = int.Parse(Console.ReadLine());
            var endSpace = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i1 = startSpace; i1 >= endSpace; i1--)
            {
                for (int i2 = startSpace; i2 >= endSpace; i2--)
                {
                    count++;
                    if(i1 + i2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({i1} + {i2} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
