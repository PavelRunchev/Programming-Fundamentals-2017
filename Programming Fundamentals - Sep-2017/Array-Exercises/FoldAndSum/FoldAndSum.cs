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
            var sequenceNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = sequenceNumber.Length / 4;
            int[] leftArr = sequenceNumber.Take(k).Reverse().ToArray();
            int[] rightArr = sequenceNumber.Reverse().Take(k).ToArray();
            int[] middleArr = sequenceNumber.Skip(k).Take(2 * k).ToArray();
            int[] foldArr = leftArr.Concat(rightArr).ToArray();
            int[] sumArr = new int[middleArr.Length];
            for (int i = 0; i < middleArr.Length; i++)
            {
                sumArr[i] = middleArr[i] + foldArr[i];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
