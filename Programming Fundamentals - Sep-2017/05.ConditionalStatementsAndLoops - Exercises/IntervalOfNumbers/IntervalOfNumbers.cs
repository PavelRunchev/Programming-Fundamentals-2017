using System;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var smallNumber = Math.Min(firstNumber, secondNumber);
            var LargeNumber = Math.Max(firstNumber, secondNumber);
            for (int i = smallNumber; i <= LargeNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
