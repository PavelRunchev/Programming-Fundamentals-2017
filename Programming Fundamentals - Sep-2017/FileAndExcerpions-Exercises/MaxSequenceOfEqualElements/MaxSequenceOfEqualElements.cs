using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            string inputFilePath = @"..\..\input.txt";
            if (!File.Exists(inputFilePath))
            {
                File.Create(@"..\..\input.txt");
            }

            string[] input = File.ReadAllLines(inputFilePath);
            File.WriteAllText(@"..\..\output.txt", string.Empty);

            for (int q = 0; q < input.Length; q++)
            {
                int[] inputNumber = input[q].Split(' ').Select(int.Parse).ToArray();

                int start = 0;
                List<int> length = new List<int>();
                List<int> bestLength = new List<int>();
                length.Add(inputNumber[0]);
                for (int i = 1; i < inputNumber.Length; i++)
                {
                    int prevNumber = inputNumber[i - 1];
                    int currentNumber = inputNumber[i];
                    if (currentNumber == prevNumber)
                    {
                        length.Add(currentNumber);
                    }
                    else
                    {
                        if (length.Count > bestLength.Count)
                        {
                            bestLength = new List<int>(length);
                        }
                        length.Clear();
                        length.Add(currentNumber);
                    }
                }
                if (length.Count > bestLength.Count)
                {
                    bestLength = new List<int>(length);
                }

                string output = string.Join(" ", bestLength);
                File.AppendAllText(@"..\..\output.txt", output + Environment.NewLine);
            }           
        }
    }
}
