using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class SumArray
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var len1 = arr1.Length;
            var len2 = arr2.Length;
            int maxLen = Math.Max(len1, len2);

            var sumArr = new int[maxLen];
            
            for (int i = 0; i < maxLen; i++)
            {
                var sum = 0;
                sum += arr1[i % len1];
                sum += arr2[i % len2];
                sumArr[i] = sum;
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
