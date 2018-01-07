using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class MaxCombination
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombination = int.Parse(Console.ReadLine());

            var countMax = 0;
            for (int i = start; i <= end; i++)
            {
                for (int c = start; c <= end; c++)
                {
                    countMax++;
                    Console.Write($"<{i}-{c}>");
                    if (countMax == maxCombination)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }
        }
    }
}
