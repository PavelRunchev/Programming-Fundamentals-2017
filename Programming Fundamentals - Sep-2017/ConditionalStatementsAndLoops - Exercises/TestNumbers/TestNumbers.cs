using System;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxNumber = int.Parse(Console.ReadLine());

            var count = 0;
            var sum = 0;
            for (int cnt1 = n; cnt1 >= 1; cnt1--)
            {
                for (int cnt2 = 1; cnt2 <= m; cnt2++)
                {
                    sum += cnt1 * 3 * cnt2;
                    count++;
                    if(sum >= maxNumber)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
