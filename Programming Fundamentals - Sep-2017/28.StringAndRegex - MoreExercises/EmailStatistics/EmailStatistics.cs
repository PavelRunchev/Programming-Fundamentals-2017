using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailStatistics
{
    class EmailStatistics
    {
        static void Main()
        {
            var dataEmails = new Dictionary<string, List<string>>();
            int numberOfEmails = int.Parse(Console.ReadLine());

            string pattern = @"\b(?<user>[A-Za-z]{5,})@(?<mail>[a-z]{3,}[.](bg|org|com))\b";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < numberOfEmails; i++)
            {
                string inputEmails = Console.ReadLine().Trim();
                Match matchedEmail = regex.Match(inputEmails);
                if (matchedEmail.Success)
                {
                    string user = matchedEmail.Groups["user"].Value;
                    string mail = matchedEmail.Groups["mail"].Value;
                    if (!dataEmails.ContainsKey(mail))
                    {
                        dataEmails.Add(mail, new List<string>());
                        dataEmails[mail].Add(user);
                    }
                    if (!dataEmails[mail].Contains(user))
                    {
                        dataEmails[mail].Add(user);
                    }
                }           
            }

            var sortedEmails = dataEmails
                .OrderByDescending(e => e.Value.Count)
                .ToDictionary(k=> k.Key, v => v.Value);

            foreach (var email in sortedEmails)
            {
                Console.WriteLine($"{email.Key}:");
                List<string> users = email.Value.Distinct().ToList();
                foreach (var name in users)
                {
                    Console.WriteLine($"### {name}");
                }
            }
        }
    }
}
