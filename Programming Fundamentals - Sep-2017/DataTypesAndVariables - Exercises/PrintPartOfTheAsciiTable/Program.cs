using System;
using System.Collections.Generic;

namespace PrintPartOfTheAsciiTable
{
    class Program
    {
        static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            string partAsciiTable = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                char symbol = (char)i;
                partAsciiTable += symbol + " ";
            }
            Console.WriteLine(partAsciiTable);
        }
    }
}
