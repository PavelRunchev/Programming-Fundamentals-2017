using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum_Average
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < numberOfLine; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
