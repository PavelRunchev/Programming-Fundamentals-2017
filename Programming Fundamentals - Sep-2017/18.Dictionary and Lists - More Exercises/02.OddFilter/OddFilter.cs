using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class OddFilter
    {
        static void Main()
        {
            var integer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a % 2 == 0)
                .ToArray();
            double average = integer.Average();
            var filteredElements = integer
                .Select(n => n > average ? ++n : --n)
                .ToList();
            Console.WriteLine(string.Join(" ", filteredElements));
        }
    }
}
