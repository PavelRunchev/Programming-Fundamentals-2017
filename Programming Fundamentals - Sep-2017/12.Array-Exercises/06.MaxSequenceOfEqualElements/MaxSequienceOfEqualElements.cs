using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequienceOfEqualElements
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSec = 1;
            int len = 1;
            int startPos = 0;
            bool isEqual = false;
            for (int i = 0; i < sequence.Length - 1; i++)
            {           
                if (sequence[i] == sequence[i +1])
                {
                    len++;
                    if(len > maxSec)
                    {
                        maxSec = len;
                        isEqual = true;               
                    }
                    if (isEqual)
                    {
                        startPos = (i - maxSec) + 2;
                    }
                }
                else
                {
                    len = 1;
                    if (isEqual)
                    {
                        startPos = (i - maxSec) + 1;
                        isEqual = false;
                    }                  
                }
            }

            for (int i = startPos; i < startPos + maxSec; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
