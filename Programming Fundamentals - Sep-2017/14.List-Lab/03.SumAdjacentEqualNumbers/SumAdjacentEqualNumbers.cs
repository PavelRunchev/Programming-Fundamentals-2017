using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                decimal currentNumber = numbers[i];
                decimal nextNumber = numbers[i + 1];
                if(currentNumber == nextNumber)
                {
                    decimal sum = currentNumber + nextNumber;
                    numbers[i] = sum;
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
