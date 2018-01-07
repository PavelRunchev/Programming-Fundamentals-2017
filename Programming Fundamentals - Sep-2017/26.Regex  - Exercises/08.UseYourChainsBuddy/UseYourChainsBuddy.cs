using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"<p>(?<message>.+?)<\/p>");
            var text = Console.ReadLine();
            var matchedText = regex.Matches(text)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select (x => Regex.Replace(x, @"[^a-z\d]", " "))
                .Select(x => Regex.Replace(x, @"\s+", " "))
                .ToArray();

            string result = string.Empty;
            for (int i = 0; i < matchedText.Length; i++)
            {
                result += ConvertLetters(matchedText[i]);
            }
            Console.WriteLine(result);
        }

        private static string ConvertLetters(string v)
        {
            var result = new StringBuilder();
            foreach (var letter in v)
            {
                if(letter >= 'a' && letter <= 'm')
                {
                    result.Append(((char)(letter + 13)).ToString());
                }
                else if(letter >= 'n' && letter <= 'z')
                {
                    result.Append(((char)(letter - 13)).ToString());
                }
                else
                {
                    result.Append(letter.ToString());
                }
            }
            return result.ToString();
        }
    }
}
