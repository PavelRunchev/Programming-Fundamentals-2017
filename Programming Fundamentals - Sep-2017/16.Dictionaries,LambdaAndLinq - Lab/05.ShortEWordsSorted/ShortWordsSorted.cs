using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortEWordsSorted
{
    class ShortWordsSorted
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .Distinct()
                .OrderBy(word => word)
                .ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
