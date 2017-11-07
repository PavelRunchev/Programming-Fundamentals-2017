using System;
using System.Collections.Generic;


namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                int sumOfDigit = 0;
                int digit = i;
                while (digit > 0)
                {
                    sumOfDigit += digit % 10;
                    digit /= 10;
                }
                bool specialDigit = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
               
                Console.WriteLine($"{i} -> {specialDigit}");
            }
        }
    }
}
