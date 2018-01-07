using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largst3Numbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(num => num)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
