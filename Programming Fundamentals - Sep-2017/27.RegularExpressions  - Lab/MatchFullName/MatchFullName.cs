using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            
            MatchCollection matchNames = Regex.Matches(input, pattern);
            foreach (Match name in matchNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
