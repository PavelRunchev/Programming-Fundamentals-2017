using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Censorship
{
    class Censorship
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            Console.WriteLine(Regex.Replace(sentence, word ,new string('*', word.Length)));
        }
    }
}
