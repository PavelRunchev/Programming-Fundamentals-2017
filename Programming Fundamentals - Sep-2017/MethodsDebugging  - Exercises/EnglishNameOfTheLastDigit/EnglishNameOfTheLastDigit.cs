using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            string lastDigit = GetLastDigit(number);
            Console.WriteLine(lastDigit);
        }

        private static string GetLastDigit(long number)
        {
            var dataDigits = new Dictionary<double, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" },
                { 3, "three" }, { 4, "four" }, { 5, "five" },
                { 6, "six" }, { 7, "seven" }, { 8, "eight" },
                { 9, "nine" }
            };
            double digit = Math.Abs(number) % 10;

            return dataDigits[digit];
        }
    }
}
