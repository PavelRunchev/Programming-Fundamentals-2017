using System;
using System.Text;
using System.Text.RegularExpressions;

namespace xtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";
            var text = Console.ReadLine();
            var emails = Regex.Matches(text, pattern);
            foreach (Match email in emails)
            {
                Console.WriteLine(email.ToString());
            }
        }
    }
}
