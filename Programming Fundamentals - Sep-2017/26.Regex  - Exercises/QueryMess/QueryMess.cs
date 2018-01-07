using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class QueryMess
    {
        static void Main()
        {           
            string input = Console.ReadLine();
            while(input != "END")
            {
                var dataQuery = new Dictionary<string, List<string>>();        
                string pattern = @"(?<key>[^&=?]*)=(?<value>[^&=]*)";
                string replayPattern = @"((\+|%20)+)";
                Regex regex = new Regex(pattern);

                foreach (Match item in regex.Matches(input))
                {
                    string key = item.Groups["key"].Value;
                    key = Regex.Replace(key, replayPattern, " ").Trim();
                    string value = item.Groups["value"].Value;
                    value = Regex.Replace(value, replayPattern, " ").Trim();
                    if (!dataQuery.ContainsKey(key))
                    {
                        dataQuery.Add(key, new List<string>());
                    }
                    dataQuery[key].Add(value);
                }
                foreach (var query in dataQuery)
                {
                    if(query.Value.Count > 1)
                    {
                        Console.Write($"{query.Key}=[{string.Join(", ", query.Value)}]");
                    }
                    else
                    {
                        Console.Write($"{query.Key}=[{string.Join("", query.Value)}]");
                    }            
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }          
        }
    }
}
