using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SortTimes
{
    class SortTimes
    {
        static void Main()
        {
            var time = Console.ReadLine()
                .Split(' ')
                .OrderBy(d => d)
                .ToList();
        
            Console.WriteLine(string.Join(", ", time));
        }
    }
}
