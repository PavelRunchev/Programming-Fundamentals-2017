using System;
using System.Linq;

namespace SMSTyping
{
    class SMSTyping
    {
        static void Main()
        {
            string message = string.Empty;
    
            var numberOfCharacters = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCharacters; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                int offset;
                char[] arr = digit.ToString().ToCharArray();
                int firstDigit = int.Parse(arr.First().ToString());
                int lengthDigit = arr.Length;
                if(firstDigit >= 8 && firstDigit <= 9)
                {
                    offset = ((firstDigit - 2) * 3) + 1;
                }
                else
                {
                    offset = (firstDigit - 2) * 3;
                }
                
                int index = offset + lengthDigit - 1;

                if(index < 0 || index > 26)
                {
                    message += " ";
                }
                else
                {
                    message += (char)(97 + index);
                }              
            }
            Console.WriteLine(message);
        }
    }
}
