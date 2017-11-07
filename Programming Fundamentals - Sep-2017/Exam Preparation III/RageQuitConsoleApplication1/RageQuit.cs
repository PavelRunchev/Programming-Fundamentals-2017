using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class RageQuit
    {
        static void Main()
        {
            string pattern = @"([^0-9]+)(\d+)";
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                string word = m.Groups[1].Value;
                int count = int.Parse(m.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word.ToUpper());
                }
            }
            int countSymbols = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {countSymbols}");
            Console.WriteLine(result.ToString());
        }
    }
}
