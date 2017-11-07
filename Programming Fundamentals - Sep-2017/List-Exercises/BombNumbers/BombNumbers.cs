using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = bombInput[0];
            int power = bombInput[1];

            for (int i = 0; i < sequence.Count; i++)
            {
                int leftPower = i - power;
                int rightPower = i + power;
                if (sequence[i] == bomb)
                {
                    if(leftPower < 0)
                    {
                        leftPower = 0;
                    }
               
                    if(rightPower > sequence.Count)
                    {
                        rightPower = sequence.Count - 1;
                    }
                    rightPower = rightPower - leftPower + 1;
                    sequence.RemoveRange(leftPower, rightPower);
                    i = -1;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
