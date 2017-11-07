using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection matchedNumbers = Regex.Matches(input, pattern);
            foreach (Match number in matchedNumbers)
            {
                Console.Write($"{number.Value}" + " ");
            }
            Console.WriteLine();
        }
    }
}
