using System;
using System.Linq;
using System.IO;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            string inputFilePath = @"..\..\input.txt";
            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }

            string[] input = File.ReadAllLines(inputFilePath);
            File.WriteAllText("..\\..\\output.txt", string.Empty);

            for (int k = 0; k < input.Length; k++)
            {
                int[] sequence = input[k].Split(' ')
                    .Select(int.Parse)
                    .ToArray(); ;

                int besCount = 0;
                int count = 0;
                int maximumNumbers = 0;
                for (int i = 0; i < sequence.Length; i++)
                {
                    int num = sequence[i];
                    for (int j = 0; j < input.Length; j++)
                    {
                        int searchNumber = sequence[j];
                        if (num == searchNumber)
                        {
                            count++;
                            if (count > besCount)
                            {
                                besCount = count;
                                maximumNumbers = num;
                            }
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                }

                var output = $"{maximumNumbers}" + Environment.NewLine;
                File.AppendAllText("..\\..\\output.txt", output);
            }          
        }
    }
}
