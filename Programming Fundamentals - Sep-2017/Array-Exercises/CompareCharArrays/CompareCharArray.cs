using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArray
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split();
            var arr2 = Console.ReadLine().Split();

            string word1 = string.Join("", arr1).ToString();
            string word2 = string.Join("", arr2).ToString();
            if (word1.CompareTo(word2) < 0)
            {
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }
            else
            {
                Console.WriteLine(word2);
                Console.WriteLine(word1);
            }
        }
    }
}
