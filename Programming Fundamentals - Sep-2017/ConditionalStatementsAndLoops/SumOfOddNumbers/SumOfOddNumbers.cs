using System;

namespace SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;
            int index = 1;
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 1 && index <= n)
                {
                    Console.WriteLine(i);
                    sum += i;
                    index++;
                }
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
