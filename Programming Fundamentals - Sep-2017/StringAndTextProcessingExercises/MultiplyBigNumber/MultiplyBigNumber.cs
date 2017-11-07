using System;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            string numbers = Console.ReadLine().TrimStart('0');
            int digit = int.Parse(Console.ReadLine());
            if(digit == 0)
            {
                Console.WriteLine(0);
                return;
            }

            string result = string.Empty;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = int.Parse(numbers[numbers.Length - 1 - i].ToString()) * digit + index;
                index = sum / 10;
                sum = sum % 10;               
                result = sum + result;
            }
            if(index != 0)
            {
                result = index + result;
            }
            Console.WriteLine(result);
        }
    }
}
