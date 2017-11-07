using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            int count = 0;
            while (true)
            {
                int temp = (int)(factorial % 10);
                if(temp == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                factorial /= 10;
            }
            Console.WriteLine(count);
        }
    }
}
