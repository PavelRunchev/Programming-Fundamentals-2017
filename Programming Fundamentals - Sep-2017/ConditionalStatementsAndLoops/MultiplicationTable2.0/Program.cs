using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var multiplication = int.Parse(Console.ReadLine());

            for (int i = multiplication; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
            if(multiplication > 10)
            {
                Console.WriteLine($"{num} X {multiplication} = {num * multiplication}");
            }
        }
    }
}
