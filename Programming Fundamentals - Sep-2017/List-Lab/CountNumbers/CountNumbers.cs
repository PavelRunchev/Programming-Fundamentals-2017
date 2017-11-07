using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            int prevNumber = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if(currentNumber != prevNumber)
                {
                    Console.WriteLine($"{prevNumber} -> {count}");
                    prevNumber = currentNumber;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine($"{prevNumber} -> {count}");
        }
    }
}
