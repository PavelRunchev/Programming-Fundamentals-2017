using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var searchingList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int take = searchingList[0];
            int delete = searchingList[1];
            int search = searchingList[2];
            var takeElements = numbers.Take(take).ToList();
            var deletedElements = takeElements.Skip(delete).ToList();

            bool isFindedElement = deletedElements.Any(el => el == search);
            Console.WriteLine(isFindedElement ? "YES!" : "NO!");
        }
    }
}
