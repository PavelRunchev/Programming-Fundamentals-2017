using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConvertFromBase_NToBase_10
{
    class ConvertFromBaseNToBase10
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();
            BigInteger number = input[1];
            BigInteger BaseN = input[0];

            int index = 0;
            BigInteger sum = 0;
            while (number > 0)
            {
                BigInteger remainder = number % 10;
                sum += remainder * BigInteger.Pow(BaseN, index);
                number /= 10;
                index++;
            }
            Console.WriteLine(sum);
        }
    }
}
