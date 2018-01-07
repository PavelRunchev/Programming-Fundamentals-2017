using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    class Spyfer
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < sequence.Count; i++)
            {
                int currentElement = sequence[i];
                int leftNeighBour = i - 1 < 0 ? 0 : sequence[i - 1];
                int rightNeighBour = i + 1 > sequence.Count - 1 ? 0 : sequence[i + 1];
                if(leftNeighBour + rightNeighBour == currentElement)
                {
                    if(i + 1 < sequence.Count)
                    {
                        sequence.RemoveAt(i + 1);
                    }
                    if (i - 1 > -1)
                    {
                        sequence.RemoveAt(i - 1);
                    }
                    i = -1;
                }             
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
