using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ');
            while(command[0] != "print")
            {
                int index = 0;
                int element = 0;
                switch (command[0])
                {
                    case "add":
                        index = int.Parse(command[1]);
                        element = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(command[1]);
                        int[] elements = command.Skip(2).Select(int.Parse).ToArray();
                        numbers.InsertRange(index, elements);
                        break;
                    case "contains":
                        element = int.Parse(command[1]);
                        int containIndex = numbers.IndexOf(element);
                        Console.WriteLine(containIndex > -1 ? containIndex : containIndex);
                        break;
                    case "remove":
                        index = int.Parse(command[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "shift":
                        int position = int.Parse(command[1]);
                        numbers = ShiftArrayToLeftPosition(numbers, position);
                        break;
                    case "sumPairs":
                        numbers = SumPairsToArray(numbers);
                        break;
                }
                command = Console.ReadLine().Split(' ');
            }

            PrintArray(numbers);
        }

        private static List<int> SumPairsToArray(List<int> numbers)
        {
            var sumList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int firstDigit = numbers[i];
                int secondDigit = i + 1;
                if (secondDigit >= numbers.Count)
                {
                    secondDigit = 0;
                }
                else
                {
                    secondDigit = numbers[i + 1];
                }
                sumList.Add(firstDigit + secondDigit);
                i++;
            }
            
            return sumList;
        }

        private static List<int> ShiftArrayToLeftPosition(List<int> numbers, int position)
        {
            for (int i = 0; i < position; i++)
            {
                int firstPosition = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstPosition);
            }
            return numbers;
        }

        private static void PrintArray(List<int> numbers)
        {
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
