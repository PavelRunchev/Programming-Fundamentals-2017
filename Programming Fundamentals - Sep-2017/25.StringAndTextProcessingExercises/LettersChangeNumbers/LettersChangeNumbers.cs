using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" \t".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (var item in input)
            {
                double sum = 0;
                char firstLetter = item.First();
                char lastLetter = item.Last();
                double digit = double.Parse(item.Substring(1, item.Length - 2));
                sum = char.IsUpper(firstLetter)
                    ? digit / (firstLetter - 65 + 1) : digit * (firstLetter - 97 + 1);
                sum = char.IsUpper(lastLetter)
                    ? sum - (lastLetter - 65 + 1) : sum + (lastLetter - 97 + 1);
                totalSum += sum;
            }
            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
