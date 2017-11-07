using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main()
        {
            char[] separators = new char[] { ' ', '/', '\\', '(', ')' };
            string[] input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"^[A-Za-z][A-Za-z0-9_]{2,24}$");
            List<string> users = new List<string>();
            foreach (var username in input)
            {
                if (regex.IsMatch(username))
                {
                    users.Add(username);
                }
            }

            int bestLength = 0;
            int sumLength = 0;
            int index = 0;
            for (int i = 0; i < users.Count - 1; i++)
            {
                sumLength = users[i].Length + users[i + 1].Length;
                if(sumLength > bestLength)
                {
                    bestLength = sumLength;
                    index = i;
                }
            }

            Console.WriteLine(users[index]);
            Console.WriteLine(users[index + 1]);
        }
    }
}
