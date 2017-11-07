using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var len = 0;
            var num1 = 0;
            var max = 0;
            for (int i = 0; i < n; i++)
            {             
                var num = int.Parse(Console.ReadLine());
                
                if((num > num1) || (i == 0))
                {
                    len++;
                }
                else
                {
                    len = 1;
                }
                if (len > max) max = len;
                num1 = num;
            }
            Console.WriteLine(max);
        }
    }
}
