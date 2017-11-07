using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] delimiters = { ' ', '.', ',', '!', '?' };
            string[] text = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromList = new List<string>();
             
            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                if (isPalindrom(word))
                {
                    palindromList.Add(word);
                }
            }

            palindromList = palindromList
                .Distinct()
                .OrderBy(l => l)
                .ToList();
            Console.WriteLine(string.Join(", ", palindromList));
        }

        private static bool isPalindrom(string word)
        {
            bool isPalindrom = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                char firstLetter = word[i];
                char lastLetter = word[word.Length - 1 - i];
                if(firstLetter != lastLetter)
                {
                    return false;
                }
            }
            return isPalindrom;
        }
    }
}
