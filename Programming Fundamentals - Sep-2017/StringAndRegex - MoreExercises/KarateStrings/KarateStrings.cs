using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarateStrings
{
    class KarateStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            int punch = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    punch += int.Parse(input[i + 1].ToString());
                }
                else if(punch > 0)
                {
                    punch--;
                    continue;
                }
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
