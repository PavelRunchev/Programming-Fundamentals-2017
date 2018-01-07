using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class Numberchecker
    {
        static void Main()
        {
            var number = decimal.Parse(Console.ReadLine());
            long num;
            if(long.TryParse(number.ToString(), out num))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
