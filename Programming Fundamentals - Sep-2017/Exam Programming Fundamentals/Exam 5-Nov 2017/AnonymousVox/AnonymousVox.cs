using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AnonymousVox
{
    class AnonymousVox
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] checkpoints = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([a-zA-Z]+)(.+)\1";
            Regex regex = new Regex(pattern);

            MatchCollection matchedText = regex.Matches(input);

            int indexCheckpint = 0;
            foreach (Match match in matchedText)
            {
                string matched = match.Groups[2].Value;
                int index = input.IndexOf(matched);
                string firstPart = input.Substring(0, index) + checkpoints[indexCheckpint++];
                string secondPart = input.Substring(index + matched.Length);
                input = firstPart + secondPart;             
            }

            Console.WriteLine(input);
        }
    }
}
