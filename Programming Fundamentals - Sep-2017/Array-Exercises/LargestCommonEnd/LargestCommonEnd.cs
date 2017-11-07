using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            var words1 = Console.ReadLine().Split();
            var words2 = Console.ReadLine().Split();

            int lenArray = Math.Min(words1.Length, words2.Length);
            int maxRight = 0;
            int maxLeft = 0;
            for (int i = 0; i < lenArray; i++)
            {
                if(words1[i] == words2[i])
                {
                    maxRight++;
                }
            }

            Array.Reverse(words1);
            Array.Reverse(words2);
            for (int i = 0; i < lenArray; i++)
            {
                if(words1[i] == words2[i])
                {
                    maxLeft++;
                }
            }

            int largestCount = Math.Max(maxRight, maxLeft);
            Console.WriteLine(largestCount);
        }
    }
}
