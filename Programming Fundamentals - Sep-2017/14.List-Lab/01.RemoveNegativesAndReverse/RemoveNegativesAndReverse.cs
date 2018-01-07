using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var filtredList = list.Where(num => num >= 0).Reverse().ToList();
            Console.WriteLine(filtredList.Count > 0 ? $"{string.Join(" ", filtredList)}" : "empty");
        }
    }
}
