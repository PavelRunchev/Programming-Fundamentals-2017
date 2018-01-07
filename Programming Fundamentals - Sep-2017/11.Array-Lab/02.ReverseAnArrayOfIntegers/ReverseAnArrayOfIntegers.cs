using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main()
        {
            var numberOfLine = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfLine];
            for (int i = 0; i < numberOfLine; i++)
            {
                array[i] = int.Parse(Console.ReadLine());              
            }
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
