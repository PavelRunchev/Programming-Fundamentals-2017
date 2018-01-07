using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string[] tokens = text
                .Split(new char[] { '.', '!', '?' }, 
                StringSplitOptions.RemoveEmptyEntries);

            List<string> listSentence = new List<string>();
            var pattern = @"\b" + keyword + @"\b";
            var regex = new Regex(pattern);
            foreach (var sentence in tokens)
            {
                if (regex.IsMatch(sentence.Trim()))
                {
                    Console.WriteLine(sentence);
                } 
            }
        }
    }
}
