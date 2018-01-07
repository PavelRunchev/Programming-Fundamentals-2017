using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailMe
{
    class EmailMe
    {
        static void Main()
        {
            var inputEmail = Console.ReadLine().Split('@');
            string user = inputEmail[0];
            string host = inputEmail[1];

            int sumUser = CalcCharacters(user);
            int sumHost = CalcCharacters(host);
          
            Console.WriteLine(sumUser >= sumHost ? "Call her!" : "She is not the one.");
        }

        private static int CalcCharacters(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                sum += (int)letter;
            }
            return sum;
        }
    }
}
