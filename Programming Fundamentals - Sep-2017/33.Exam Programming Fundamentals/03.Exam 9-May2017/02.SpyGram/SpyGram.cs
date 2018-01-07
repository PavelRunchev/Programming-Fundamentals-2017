using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SpyGram
{
    class SpyGram
    {
        static void Main()
        {
            var dataMessages = new Dictionary<string, List<string>>();
            string pattern = @"TO: (?<sender>[A-Z]+); MESSAGE: .*;";
            int[] key = Console.ReadLine().Select(a => int.Parse(a.ToString())).ToArray();
            
            string inputMessage;
            while ((inputMessage = Console.ReadLine()) != "END")
            {
                Match matchesMessage = Regex.Match(inputMessage, pattern);
                if (matchesMessage.Success)
                {
                    string sender = matchesMessage.Groups["sender"].Value;
                    string encrypt = string.Empty;
                    int indexKey = 0;
                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        
                        if(indexKey > key.Length - 1)
                        {
                            indexKey = 0;
                        }
                        char letter = inputMessage[i];
                        int pos = key[indexKey++];
                        encrypt += (char)((int)letter + pos);
                    }
                    if (!dataMessages.ContainsKey(sender))
                    {
                        dataMessages.Add(sender, new List<string>());
                    }
                    dataMessages[sender].Add(encrypt);
                }
            }

            foreach (var decrypt in dataMessages.OrderBy(a => a.Key))
            {
                Console.WriteLine(string.Join("\n",decrypt.Value));
            }
        }
    }
}
