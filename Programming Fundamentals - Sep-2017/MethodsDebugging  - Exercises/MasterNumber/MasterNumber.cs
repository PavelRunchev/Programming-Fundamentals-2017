using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class MasterNumber
    {
        static void Main()
        {
            int masterNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= masterNumber; i++)
            {
                bool isSymmetric = CheckSymmetric(i);
                bool isDivisibleBy7 = CheckDivisibleBy7(i);
                bool isOneEvenDigit = CheckOneEvenDigit(i);
                if(isSymmetric && isDivisibleBy7 && isOneEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckOneEvenDigit(int i)
        {
            while (i > 0)
            {
                int temp = i % 10;
                if(temp % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool CheckDivisibleBy7(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                int temp = i % 10;
                sum += temp;
                i /= 10;
            }
            if(sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool CheckSymmetric(int num)
        {
            char[] sym = num.ToString().ToCharArray();
            bool isSymmetrics = true;
            for (int i = 0; i < sym.Length / 2; i++)
            {
                int first = (int)sym[i];
                int last = (int)sym[sym.Length - 1 - i];
                if(first == last)
                {
                    isSymmetrics = true;
                }
                else
                {
                    isSymmetrics = false;
                    break;
                }
            }
            return isSymmetrics;
        }
    }
}
