using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            var input = Console.ReadLine();
            
            while(input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replace);
                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}
