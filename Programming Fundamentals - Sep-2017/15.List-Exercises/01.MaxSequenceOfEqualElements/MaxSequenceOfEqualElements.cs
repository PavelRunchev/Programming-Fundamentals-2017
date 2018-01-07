using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(' ').Select(long.Parse)
                .ToList();
            int bestStart = 0;
            int bestLen = 1;
            int len = 1;
            bool isEquals = false;
            for (int i = 1; i < sequence.Count; i++)
            {
                long prevElement = sequence[i - 1];
                long currentElement = sequence[i];
                if(currentElement == prevElement)
                {
                    len++;
                    if(len > bestLen)
                    {
                        bestLen = len;
                        isEquals = true;
                    }
                    if (isEquals)
                    {
                        bestStart = i - bestLen + 1;
                    }
                }
                else
                {
                    if(isEquals)
                    {
                        bestStart = i - bestLen;
                    }
                    len = 1;
                    isEquals = false;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
