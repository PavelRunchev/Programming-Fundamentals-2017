using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            var phones = Console.ReadLine();
            var patern = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";
            var phoneMathes = Regex.Matches(phones, patern);
            var matchedPhones = phoneMathes
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
