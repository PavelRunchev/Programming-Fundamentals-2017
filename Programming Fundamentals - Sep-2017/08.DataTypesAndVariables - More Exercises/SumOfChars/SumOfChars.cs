using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfLine; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
