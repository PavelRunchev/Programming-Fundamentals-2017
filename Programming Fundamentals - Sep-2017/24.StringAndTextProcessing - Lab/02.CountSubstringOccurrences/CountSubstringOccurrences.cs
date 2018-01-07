using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();

            int index = -1;
            int countWord = 0;
            while (true)
            {
                index = text.IndexOf(searchString, index + 1);
                if (index == -1)
                {
                    break;
                }
                countWord++;
            }
            Console.WriteLine(countWord);
        }
    }
}
