using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConvertFromBase_10ToBase_N
{
    class ConvertFromBase10ToBaseN
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger base10 = input[0];
            BigInteger number = input[1];
            string convertResult = string.Empty;
            while (number > 0)
            {
                BigInteger remainder = number % base10;
                number /= base10;
                convertResult = remainder + convertResult;
            }
            Console.WriteLine(convertResult);
        }
    }
}
