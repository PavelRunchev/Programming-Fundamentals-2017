using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sqrtList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    sqrtList.Add(numbers[i]);
                }
            }

            var sortedList = sqrtList.OrderByDescending(sqrt => sqrt).ToList();
            Console.WriteLine(string.Join(" ", sortedList));
        }
    }
}
