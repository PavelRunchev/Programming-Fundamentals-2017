using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main()
        {
            List<string> inputData = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries).ToList();
            string commands;
            while((commands = Console.ReadLine()) != "3:1")
            {
                var tokens = commands.Split(' ');
                string command = tokens[0];
                if(command == "merge")
                {
                    inputData = MergedArray(inputData, tokens);
                }
                else if(command == "divide")
                {
                    inputData = DivideArray(inputData, tokens);
                }
            }

            Console.WriteLine(string.Join(" ", inputData));
        }

        private static List<string> DivideArray(List<string> inputData, string[] tokens)
        {
            List<string> divideList = new List<string>();
            int index = int.Parse(tokens[1]);
            int partations = int.Parse(tokens[2]);

            string arr = inputData[index];
            string divide = string.Empty;
            int length = arr.Length / partations;
            for (int i = 0; i < partations; i++)
            {
                divide = arr.Substring(0, length);
                arr = arr.Remove(0, length);
                divideList.Add(divide);
            }
            if(arr.Length > 0)
            {
                divideList[divideList.Count - 1] += arr;
            }
            inputData.RemoveAt(index);
            inputData.InsertRange(index, divideList);
            return inputData;
        }

        private static List<string> MergedArray(List<string> inputData, string[] tokens)
        {
            int startIndex = int.Parse(tokens[1]);
            int endIndex = int.Parse(tokens[2]);
            List<string> finelConcat = new List<string>();
            if(startIndex < 0)
            {
                startIndex = 0;
            }
            if(endIndex > inputData.Count - 1)
            {
                endIndex = inputData.Count - 1;
            }

            if(startIndex > inputData.Count - 1)
            {
                return inputData;
            }
            finelConcat = inputData.Take(startIndex).ToList();
            string concat = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                concat += inputData[i];
            }
            finelConcat.Add(concat);
            var lastPart = inputData.Skip(endIndex + 1).ToList();
            finelConcat = finelConcat.Concat(lastPart).ToList();

            return finelConcat;
        }
    }
}
