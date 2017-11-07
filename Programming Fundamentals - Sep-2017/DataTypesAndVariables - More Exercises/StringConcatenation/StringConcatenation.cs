using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    class StringConcatenation
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            string evenOrOdd = Console.ReadLine();
            int numberOfLine = int.Parse(Console.ReadLine());
            string concatString = string.Empty;
            for (int i = 1; i <= numberOfLine; i++)
            {
                string word = Console.ReadLine();
                if(evenOrOdd == "even")
                {
                    if(i % 2 == 0)
                    {
                        concatString += word + delimiter;
                    }
                }
                if(evenOrOdd == "odd")
                {
                    if (i % 2 != 0)
                    {
                        concatString += word + delimiter;
                    }
                }
            }
            int index = concatString.LastIndexOf(delimiter);
            string result = concatString.Remove(index);
            Console.WriteLine(result);
        }
    }
}
