using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeUpgraded
{
    class MorseCodeUpgraded
    {
        static void Main()
        {
            string[] inputMessage = Console.ReadLine().Split('|');
            string secretMessage = string.Empty;

            for (int i = 0; i < inputMessage.Length; i++)
            {
                int sum = 0;
                int countOne = 0;
                int countZero = 0;
                string secretLetter = inputMessage[i];
                for (int g = 0; g < secretLetter.Length; g++)
                {
                    int code = int.Parse(secretLetter[g].ToString());
                    if(code == 0)
                    {
                        countZero++;
                    }
                    else if(code == 1)
                    {
                        countOne++;
                    }
                }
                sum = (countZero * 3) + (countOne * 5);
                sum += equalLetterZero(secretLetter);
                sum += equalLetterOne(secretLetter);
                secretMessage += (char)sum;
            }
            Console.WriteLine(secretMessage);
        }

        private static int equalLetterOne(string secretLetter)
        {
            int oneSum = 0;
            int count = 0;
            for (int i = 0; i < secretLetter.Length; i++)
            {
                int digit = int.Parse(secretLetter[i].ToString());
                if (digit == 1)
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        oneSum += count;
                    }
                    count = 0;
                }
            }
            if(count > 1)
            {
                oneSum += count;
            }

            return oneSum;
        }

        private static int equalLetterZero(string secretLetter)
        {
            int zeroSum = 0;
            int count = 0;
            for (int i = 0; i < secretLetter.Length; i++)
            {
                int digit = int.Parse(secretLetter[i].ToString());
                if(digit == 0)
                {
                    count++;
                }
                else 
                {
                   if(count > 1)
                    {
                        zeroSum += count;
                    }
                    count = 0;
                }
            }
            if (count > 1)
            {
                zeroSum += count;
            }

            return zeroSum;
        }
    }
}
