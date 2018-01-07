using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo
{
    class GrabAndGo
    {
        static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int searchNumber = int.Parse(Console.ReadLine());

            int index = Array.LastIndexOf(array, searchNumber);
            if(index >= 0)
            {
                long sum = 0;
                for (int i = 0; i < index; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }         
        }
    }
}
