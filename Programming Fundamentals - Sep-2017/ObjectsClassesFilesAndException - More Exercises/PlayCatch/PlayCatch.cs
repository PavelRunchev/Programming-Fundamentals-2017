using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCatch
{
    class PlayCatch
    {
        static void Main()
        {
            int[] inputSequence = Console.ReadLine()
                .Split(' ').Select(int.Parse)
                .ToArray();
            int countException = 0;
            while (countException < 3)
            {
                string[] command = Console.ReadLine().Split(' ');
                if(command[0] == "Replace")
                {
                    ReplaceIndex(command, inputSequence, ref countException);         
                }
                else if(command[0] == "Print")
                {
                    PrintArray(command, inputSequence, ref countException);
                }
                else if(command[0] == "Show")
                {
                    ShowIndexInArray(command, inputSequence, ref countException);
                }
            }

            Console.WriteLine(string.Join(", ", inputSequence));
        }

        private static void ShowIndexInArray(string[] command, int[] inputSequence, ref int countException)
        {
            try
            {
                int index = int.Parse(command[1]);               
                Console.WriteLine(inputSequence[index]);              
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                countException++;
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                countException++;
            }
        }

        private static void ReplaceIndex(string[] command, int[] inputSequence, ref int countException)
        {
            try
            {
                int index = int.Parse(command[1]);
                int element = int.Parse(command[2]);              
                inputSequence[index] = element;              
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                countException++;
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                countException++;
            }
        }

        private static void PrintArray(string[] command, int[] inputSequence,ref int countException)
        {
            List<int> list = new List<int>();
            try
            {
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                for (int i = startIndex; i <= endIndex; i++)
                {
                    list.Add(inputSequence[i]);
                }

                Console.WriteLine(string.Join(", ", list));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                countException++;
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                countException++;
            }
        }
    }
}
