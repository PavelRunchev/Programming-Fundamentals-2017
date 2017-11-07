using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            string sign = string.Empty;
            if(number == 0)
            {
                sign = PrintEqual();
            }
            else if(number > 0)
            {
                sign = PrintPositive();
            }
            else if(number < 0)
            {
                sign = PrintNegative();
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }

        private static string PrintNegative()
        {
            return "negative";
        }

        private static string PrintPositive()
        {
            return "positive";
        }

        private static string PrintEqual()
        {
            return "zero";
        }
    }
}
