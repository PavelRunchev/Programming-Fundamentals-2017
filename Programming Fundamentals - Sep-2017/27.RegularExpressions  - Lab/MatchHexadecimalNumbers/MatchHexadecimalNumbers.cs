using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            MatchCollection hexadesimalMatch = Regex.Matches(input, pattern);
            string[] hexadesimalNumbers = hexadesimalMatch
                .Cast<Match>()
                .Select(n => n.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ", hexadesimalNumbers));

        }
    }
}
