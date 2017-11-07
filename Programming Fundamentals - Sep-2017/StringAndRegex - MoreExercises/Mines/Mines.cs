using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mines
{
    class Mines
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<[A-Za-z]{2}>";
            Regex regex = new Regex(pattern);
            
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '<')
                {
                    int indexBomb = input.IndexOf('<');
                    string isBomb = input.Substring(indexBomb, 4);

                    if (regex.IsMatch(isBomb))
                    {
                        string bomb = input.Substring(indexBomb + 1, 2);
                        char firstChar = bomb[0];
                        char secondChar = bomb[1];
                        int power = Math.Abs(firstChar - secondChar);
                        int leftPower = Math.Max(0, indexBomb - power);
                        int rightPower = Math.Min(input.Length, indexBomb + 4 + power);

                        StringBuilder minesDestruction = new StringBuilder(input);
                        for (int g = leftPower; g < rightPower; g++)
                        {
                            minesDestruction[g] = '_';
                        }
                        i = rightPower;
                        input = minesDestruction.ToString();
                    }
                }              
            }
            Console.WriteLine(input);
        }
    }
}
