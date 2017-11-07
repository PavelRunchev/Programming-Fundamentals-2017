using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CubicMessages
{
    class CubicMessages
    {
        static void Main()
        {
            var dataMessages = new Dictionary<string, string>();
            string pattern = @"^(?<firstPart>\d+)(?<message>[a-zA-Z]+)(?<lastPart>[^a-zA-Z]*)$";
            string input;
            while ((input = Console.ReadLine()) != "Over!")
            {
                int number = int.Parse(Console.ReadLine());
                Regex regex = new Regex(pattern);
                Match matchedMessage = regex.Match(input);
                if (matchedMessage.Success)
                {
                    string firstPart = (matchedMessage.Groups["firstPart"].Value.ToString());
                    string message = matchedMessage.Groups["message"].Value;
                    string lastPart = matchedMessage.Groups["lastPart"].Value;

                    StringBuilder encryptMessage = new StringBuilder();
                    if (message.Length == number) 
                    {
                        string varificationCode = (firstPart + lastPart);
                      
                        for (int i = 0; i < varificationCode.Length; i++)
                        {
                            if (char.IsDigit(varificationCode[i]))
                            {
                                int digit = int.Parse(varificationCode[i].ToString());
                                if (digit >= 0 && digit < message.Length)
                                {
                                    encryptMessage.Append(message[digit]);
                                }
                                else
                                {
                                    encryptMessage.Append(" ");
                                }
                            }                        
                        }
                        dataMessages[message] = encryptMessage.ToString();
                    }
                }               
            }

            foreach (var item in dataMessages)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }
        }
    }
}
