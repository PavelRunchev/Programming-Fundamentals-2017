using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string[] filter = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < filter.Length; i++)
            {
                string banWord = filter[i];
                string banLength = new string('*', banWord.Length);
                text = text.Replace(banWord, banLength);
            }
            Console.WriteLine(text);
        }
    }
}
