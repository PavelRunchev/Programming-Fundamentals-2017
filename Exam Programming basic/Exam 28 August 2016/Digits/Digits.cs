using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main()
        {
            var digit = int.Parse(Console.ReadLine());

            var number = digit;
            var thirdDigit = number % 10;
            number /= 10;
            var secondDigit = number % 10;
            number /= 10;
            var firstDigit = number % 10;

            var row = firstDigit + secondDigit;
            var col = firstDigit + thirdDigit;

            for (int i = 0; i < row; i++)
            {
                for (int c = 0; c < col; c++)
                {
                    if(digit % 5 == 0)
                    {
                        digit -= firstDigit;
                    }
                    else if(digit % 3 == 0)
                    {
                        digit -= secondDigit;
                    }
                    else
                    {
                        digit += thirdDigit;
                    }
                    Console.Write($"{digit} ");
                }
                Console.WriteLine();
            }
        }
    }
}
