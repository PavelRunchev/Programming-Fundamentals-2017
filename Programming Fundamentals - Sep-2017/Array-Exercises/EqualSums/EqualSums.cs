using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
                .Select(int.Parse)
                .ToArray();

            bool isEqualSum = false;
            for (int i = 0; i < sequence.Length; i++)
            {
                int[] leftSide = sequence.Take(i).ToArray();
                int[] rightSide = sequence.Skip(i + 1).ToArray();
                if(leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    isEqualSum = true;
                    break;
                }
            }

            if(!isEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
