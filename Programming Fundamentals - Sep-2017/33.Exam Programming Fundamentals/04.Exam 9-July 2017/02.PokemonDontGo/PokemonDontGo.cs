using System;

using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{

    class PokemonDontGo
    {
        static void Main()
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long sumValues = 0;
            long removeElement = 0;
            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removeElement = input[0];
                    long lastElement = input[input.Count - 1];
                    input[0] = lastElement;
                    IncreaseOrDecreaseElements(ref input, removeElement);
                    sumValues += removeElement;
                }
                else if (index > input.Count - 1)
                {
                    removeElement = input[input.Count - 1];
                    long firstElement = input[0];
                    input.RemoveAt(input.Count - 1);
                    input.Add(firstElement);
                    IncreaseOrDecreaseElements(ref input, removeElement);
                    sumValues += removeElement;
                }
                else
                {
                    removeElement = input[index];
                    input.RemoveAt(index);
                    IncreaseOrDecreaseElements(ref input, removeElement);
                    sumValues += removeElement;
                }


            }
            Console.WriteLine(sumValues);
        }

        private static void IncreaseOrDecreaseElements(ref List<long> input, long removeElement)
        {
            for (int i = 0; i < input.Count; i++)
            {
                long currentElement = input[i];
                if (currentElement <= removeElement)
                {
                    input[i] = currentElement + removeElement;
                }
                else if (currentElement > removeElement)
                {
                    input[i] = currentElement - removeElement;
                }
            }
        }
    }
}