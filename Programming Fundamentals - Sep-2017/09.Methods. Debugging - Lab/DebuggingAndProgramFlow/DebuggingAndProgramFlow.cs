using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndProgramFlow
{
    class DebuggingAndProgramFlow
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvensAndOdds(Math.Abs(number));

            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvents = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvents * sumOdds;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int digit = 0;
            int sum = 0;
            while (number > 0)
            {
                digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int digit = 0;
            int sum = 0;
            while (number > 0)
            {
                digit = number % 10;
                if(digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
