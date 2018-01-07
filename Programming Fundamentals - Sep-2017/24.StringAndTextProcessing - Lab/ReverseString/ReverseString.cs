using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string reverseString = new string(Console.ReadLine()
                .ToCharArray()
                .Reverse()
                .ToArray());
            Console.WriteLine(reverseString);
        }
    }
}
