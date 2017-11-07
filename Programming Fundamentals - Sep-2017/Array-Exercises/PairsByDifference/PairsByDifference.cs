using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int currentElement = sequence[i];
                for (int k = 0; k < sequence.Length; k++)
                {
                    int equalElement = sequence[k];
                    if(currentElement - difference == equalElement)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
