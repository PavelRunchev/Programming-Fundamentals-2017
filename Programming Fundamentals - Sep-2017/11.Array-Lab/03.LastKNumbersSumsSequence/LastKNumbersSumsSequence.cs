using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                long sum = 0;
                int index = Math.Max(0, i - k);
                for (int j = index; j < i; j++)
                {
                    sum += sequence[j];
                }
                sequence[i] = sum;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
