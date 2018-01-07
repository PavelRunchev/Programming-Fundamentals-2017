using System;
using System.Collections.Generic;
using System.Linq;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main()
        {
            var number1 = Console.ReadLine().TrimStart('0');
            var number2 = Console.ReadLine().TrimStart('0');

            if(number1.Length > number2.Length)
            {
                number2 = number2.PadLeft(number1.Length, '0');
            }
            else
            {
                number1 = number1.PadLeft(number2.Length, '0');
            }
            Console.WriteLine(CalcNumbers(number1, number2));
        }

        private static string CalcNumbers(string number1, string number2)
        {
            string result = string.Empty;
            int sum = 0;
            int index = 0;
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(number1[i].ToString()) + int.Parse(number2[i].ToString()) + index;
                index = sum / 10;
                sum = sum % 10;            
                result = sum + result;
                
            }
            if (index != 0)
            {
                result = index + result;
            }
            return result;
        }
    }
}
