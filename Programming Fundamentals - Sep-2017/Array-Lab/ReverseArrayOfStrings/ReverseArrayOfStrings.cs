using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Array.Reverse(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
