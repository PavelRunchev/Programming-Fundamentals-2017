using System;
using System.Text;


namespace AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }
    }
}
