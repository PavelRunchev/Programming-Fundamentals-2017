using System;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            bool isFound = false;
            var firstNumber = 0;
            var secondNumber = 0;
            var count = 0;
            for (int i = n; i <= m; i++)
            {
                for (int c = n; c <= m; c++)
                {
                    count++;
                    if (i + c == magicNumber)
                    {
                        firstNumber = i;
                        secondNumber = c;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
