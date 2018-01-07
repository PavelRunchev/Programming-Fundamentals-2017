using System;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(number, 16);
            Console.WriteLine(hexadecimal.ToUpper());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }
    }
}
