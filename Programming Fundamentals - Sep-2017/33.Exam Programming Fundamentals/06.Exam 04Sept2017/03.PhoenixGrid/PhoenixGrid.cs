using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PhoenixGrid
{
    class PhoenixGrid
    {
        static void Main()
        {
            string pattern = @"^([^\s_]{3}\.)+([^\s_])*$";
            Regex regex = new Regex(pattern);
            string inputMessage;
            while ((inputMessage = Console.ReadLine()) != "ReadMe")
            {
                bool isPalindrome = true;
                Match matchesMessage = regex.Match(inputMessage);
                if(inputMessage.Length == 3 
                    && !inputMessage.Contains(" ") 
                    && !inputMessage.Contains("_")
                    || matchesMessage.Success)
                {
                    for (int i = 0; i < inputMessage.Length / 2; i++)
                    {
                        char first = inputMessage[i];
                        char last = inputMessage[inputMessage.Length - 1 - i];
                        if(first == last)
                        {
                            isPalindrome = true;
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            isPalindrome = false;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    continue;
                }

                if (isPalindrome)
                {
                    Console.WriteLine("YES");
                }              
            }
        }
    }
}
