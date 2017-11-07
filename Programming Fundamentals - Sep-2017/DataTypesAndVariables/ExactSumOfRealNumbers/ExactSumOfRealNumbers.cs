using System;

namespace ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main()
        {
            var numberOfDigits = int.Parse(Console.ReadLine());
            var sum = 0m;
            for (int i = 0; i < numberOfDigits; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
