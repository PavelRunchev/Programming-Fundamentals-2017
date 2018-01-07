using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len = new int[sequence.Length];
            var prev = new int[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
            }

            int bestLen = 0;
            int lenIndex = 0;
            for (int index = 0; index < sequence.Length; index++)
            {
                int num = sequence[index];
                int length = 1;

                for (int i = 0; i < index; i++)
                {
                    int nextNem = sequence[i];
                    if (nextNem < num && len[i] + 1 > len[index])
                    {
                        length++;
                        if (length != 1)
                        {
                            prev[index] = i;
                            len[index] = length;
                        }
                    }
                }
                if (len[index] > bestLen)
                {
                    bestLen = len[index];
                    lenIndex = index;
                }
            }

            PrintLongestSubsequence(sequence, len, prev, lenIndex);
        }

        private static void PrintLongestSubsequence(int[] sequence, int[] len, int[] prev, int lenIndex)
        {
            var longestList = new List<int>();
            for (int i = lenIndex; i >= 0;)
            {
                int number = sequence[i];
                longestList.Add(number);
                i = prev[i];
            }
            longestList.Reverse();
            Console.WriteLine(string.Join(" ", longestList));
        }
    }
}
