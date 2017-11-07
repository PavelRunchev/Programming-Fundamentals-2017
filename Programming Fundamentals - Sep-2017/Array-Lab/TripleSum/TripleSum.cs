using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            bool isTripleSum = false;
            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        if(numbers[a] + numbers[b] == numbers[c])
                        {
                            Console.WriteLine($"{numbers[a]} + {numbers[b]} == {numbers[c]}");
                            isTripleSum = true;
                            break;
                        }
                    }
                }
            }
            if(!isTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
