using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Regexmon
    {
        static void Main()
        {
            string didimonPattern = @"(?<didimon>[^A-Za-z\-]+)";
            string bojomonPatern = @"(?<bojomon>[A-Za-z]+-[A-Za-z]+)";          

            string input = Console.ReadLine();
            Regex didiRegex = new Regex(didimonPattern);
            Regex bojoRegex = new Regex(bojomonPatern);
            int i = 0;

            while (true)
            {
                if(i % 2 == 0)
                {
                    Match didiMatched = didiRegex.Match(input);
                    if (didiMatched.Success)
                    {
                        string didimon = didiMatched.Value;
                        Console.WriteLine(didiMatched);
                        int index = didiMatched.Length;
                        int findIndex = input.IndexOf(didimon);
                        input = input.Remove(0, findIndex + index);
                    }
                    else
                    {
                        break;
                    }
                }
                else if(i % 2 != 0)
                {
                    Match bojoMathed = bojoRegex.Match(input);
                    if (bojoMathed.Success)
                    {
                        string bojomon = bojoMathed.Value;
                        Console.WriteLine(bojomon);
                        int index = bojoMathed.Length;
                        int findIndex = input.IndexOf(bojomon);
                        input = input.Remove(0, findIndex + index);
                    }
                    else
                    {
                        break;
                    }
                }
                i++;
            }
        }
    }
}
