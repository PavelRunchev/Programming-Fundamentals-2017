using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            var moves = 0;
            var numberSum = 0;
            for (int i1 = 1; i1 <= N; i1++)
            {
                for (int i2 = M; i2 >= 1; i2--)
                {
                    numberSum += i1 * 2 + i2 * 3;
                    moves++;
                    if(numberSum >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves\nScore: {numberSum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{moves} moves");
        }
    }
}
