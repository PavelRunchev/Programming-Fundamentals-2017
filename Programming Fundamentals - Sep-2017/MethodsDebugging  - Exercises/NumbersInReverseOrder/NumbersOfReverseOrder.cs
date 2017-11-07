using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReverseOrder
{
    class NumbersOfReverseOrder
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            StringBuilder reversed = GetReverseNumbers(numbers);
            Console.WriteLine(reversed);
        }

        private static StringBuilder GetReverseNumbers(string numbers)
        {
            char[] num = numbers.ToArray();
            Array.Reverse(num);
            StringBuilder reverse = new StringBuilder();
            for (int i = 0; i < num.Length; i++)
            {
                reverse.Append(num[i]);
            }

            return reverse;
        }
    }
}
