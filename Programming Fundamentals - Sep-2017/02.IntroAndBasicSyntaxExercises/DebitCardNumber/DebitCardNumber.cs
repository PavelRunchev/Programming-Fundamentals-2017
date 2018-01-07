using System;
using System.Text;


namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.Write($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
            Console.WriteLine();         
        }
    }
}
