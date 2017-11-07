using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxLen = 1;
            int len = 1;
            int startPos = 0;
            bool isIncreasElement = false;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if(sequence[i] < sequence[i + 1])
                {
                    len++;
                    if(len > maxLen)
                    {
                        maxLen = len;
                        isIncreasElement = true;
                    }
                    if (isIncreasElement)
                    {
                        startPos = (i - maxLen) + 2;
                    }
                }
                else
                {
                    len = 1;
                    if (isIncreasElement)
                    {
                        startPos = (i - maxLen) + 1;
                        isIncreasElement = false;
                    }
                }
            }

            for (int i = startPos; i < startPos + maxLen; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
