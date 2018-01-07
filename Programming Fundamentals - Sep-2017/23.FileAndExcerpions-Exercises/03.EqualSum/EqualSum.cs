using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace EqualSum
{
    class EqualSum
    {
        static void Main()
        {
            string inputFilePath = "..\\..\\input.txt";
            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }
            string[] input = File.ReadAllLines(inputFilePath);

            File.WriteAllText("..\\..\\output.txt", string.Empty);
            for (int i = 0; i < input.Length; i++)
            {
                var array = input[i].Split(' ').Select(int.Parse).ToArray();

                int index = 0;
                bool isEqualSum = false;
                for (int g = 0; g < array.Length; g++)
                {
                    int leftSum = 0;
                    int rightSum = 0;
                    for (int l = 0; l < g; l++)
                    {
                        leftSum += array[l];
                    }

                    for (int r = g + 1; r < array.Length; r++)
                    {
                        rightSum += array[r];
                    }

                    if (leftSum == rightSum)
                    {
                        index = g;
                        isEqualSum = true;
                        break;
                    }
                }
                string output = isEqualSum ? $"{index}" : "no";
                File.AppendAllText("..\\..\\output.txt", output + Environment.NewLine);
            }          
        }
    }
}
