using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class KeyReplacer
    {
        static void Main()
        {
            var delimiter = @"(?<startKey>[a-zA-Z]+)(\<|\||\\)(?:.+)(\<|\||\\)(?<endKey>[a-zA-Z]+)";
            var inputKeys = Console.ReadLine();
            var matchedKeys = Regex.Match(inputKeys, delimiter);
                
            string startKey = matchedKeys.Groups["startKey"].Value;
            string endKey = matchedKeys.Groups["endKey"].Value;
            string result = string.Empty;

            var pattern = $@"{startKey}(?<word>.*?){endKey}";
            var text = Console.ReadLine();

            MatchCollection matchedText = Regex.Matches(text, pattern);
            foreach (Match word in matchedText)
            {
                result += word.Groups["word"].Value;
            }
            
            Console.WriteLine(result.Length == 0 ? "Empty result" : result);
        }
    }
}
