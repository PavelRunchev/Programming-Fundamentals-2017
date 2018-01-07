using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));          
        }

        private static int Fibonacci(int n)
        {
                int f0 = 0;
                int f1 = 1;
                for (int i = 0; i <= n; i++)
                {
                    int temp = f0 + f1;
                    f0 = f1;
                    f1 = temp;
                }
            return f0;
        }
    }
}
