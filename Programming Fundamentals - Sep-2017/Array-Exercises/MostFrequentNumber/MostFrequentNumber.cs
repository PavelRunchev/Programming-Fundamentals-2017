using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCount = 0;
            int element = 0;
            
            for (int i = 0; i < sequence.Length; i++)
            {
                int count = 0;
                int curentElement = sequence[i];
                for (int k = 0; k < sequence.Length; k++)
                {
                    int searchElement = sequence[k];
                    if(curentElement == searchElement)
                    {
                        count++;
                        if(count > maxCount)
                        {
                            maxCount = count;
                            element = curentElement;
                        }
                    }
                }
            }
            Console.WriteLine(element);
        }
    }
}
