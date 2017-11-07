using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOdTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = start; i <= end; i++)
            {
                for (int c = start; c <= end; c++)
                {
                    count++;
                    if(i + c == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {c} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
