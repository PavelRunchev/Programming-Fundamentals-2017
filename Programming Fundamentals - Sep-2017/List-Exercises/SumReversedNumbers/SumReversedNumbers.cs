using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            long sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                char[] digit = numbers[i].ToCharArray();
                Array.Reverse(digit);
                sum += long.Parse(string.Join("", digit));
            }
            Console.WriteLine(sum);
        }
    }
}
