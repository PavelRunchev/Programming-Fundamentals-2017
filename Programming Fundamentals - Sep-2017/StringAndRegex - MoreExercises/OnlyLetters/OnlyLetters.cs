using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlyLetters
{
    class OnlyLetters
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string onlyLetters = string.Empty;
            string queue = string.Empty;

            bool isDigit = false;
            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                    queue += letter;
                }
                else
                {
                    if (isDigit)
                    {
                        onlyLetters += letter;
                        isDigit = false;
                        queue = string.Empty;
                    }                  
                    onlyLetters += letter;  
                }
            }
         
            if(queue != string.Empty)
            {
                onlyLetters += queue;
            }

            Console.WriteLine(onlyLetters);
        }
    }
}
