using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            List<int> firstFold = input.Take(k).Reverse().ToList();
            List<int> lastFold = input.Reverse().Take(k).ToList();
            List<int> concatList = firstFold.Concat(lastFold).ToList();
            List<int> middleList = input.Skip(k).Take(2 * k).ToList();         
            
            List<int> resultFold = new List<int>();
            for (int i = 0; i < middleList.Count; i++)
            {
                resultFold.Add(middleList[i] + concatList[i]);
            }

            Console.WriteLine(string.Join(" ", resultFold));
        }
    }
}
