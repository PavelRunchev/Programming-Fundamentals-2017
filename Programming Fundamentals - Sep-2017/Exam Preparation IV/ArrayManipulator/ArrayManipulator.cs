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
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string commandsInput;
            while((commandsInput = Console.ReadLine()) != "end")
            {
                string[] tokens = commandsInput.Split(' ');
                string command = tokens[0];
                if(command == "exchange")
                {
                    ExchangeArray(tokens, ref input);
                }
                else if(command == "max")
                {
                    MaxElement(tokens, input);
                }
                else if(command == "min")
                {
                    MinElement(tokens, input);
                }
                else if(command == "first")
                {
                    GetFirstElements(tokens, input);
                }
                else if(command == "last")
                {
                    GetLastElements(tokens, input);
                }
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static void GetLastElements(string[] tokens, List<int> input)
        {
            int count = int.Parse(tokens[1]);
            string type = tokens[2];
            if (count > input.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (type == "even")
                {
                    var lastEvenElement = input.Where(d => d % 2 == 0).Reverse().Take(count).Reverse().ToList();
                    Console.WriteLine($"[{string.Join(", ", lastEvenElement)}]");
                }
                else if (type == "odd")
                {
                    var lastOddElement = input.Where(d => d % 2 != 0).Reverse().Take(count).Reverse().ToList();
                    Console.WriteLine($"[{string.Join(", ", lastOddElement)}]");
                }
            }
        }

        private static void GetFirstElements(string[] tokens, List<int> input)
        {
            int count = int.Parse(tokens[1]);
            string type = tokens[2];
            if(count > input.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if(type == "even")
                {
                    var firstEvenElement = input.Where(d => d % 2 == 0).Take(count).ToList();
                    Console.WriteLine($"[{string.Join(", ", firstEvenElement)}]");
                }
                else if(type == "odd")
                {
                    var firstEvenElement = input.Where(d => d % 2 != 0).Take(count).ToList();
                    Console.WriteLine($"[{string.Join(", ", firstEvenElement)}]");
                }
            }
        }

        private static void MinElement(string[] tokens, List<int> input)
        {
            string type = tokens[1];
            if(type == "even")
            {
                long evenIndex = GetMinEvenIndex(input);
                Console.WriteLine(evenIndex != long.MaxValue ? $"{evenIndex}" : "No matches");
            }
            else if(type == "odd")
            {
                long oddIndex = GetMinOddIndex(input);
                Console.WriteLine(oddIndex != long.MaxValue ? $"{oddIndex}" : "No matches");
            }
        }

        private static long GetMinOddIndex(List<int> input)
        {
            long index = long.MaxValue;
            int minDigit = int.MaxValue;
            for (int i = 0; i < input.Count; i++)
            {
                int digit = input[i];
                if (digit % 2 != 0)
                {
                    if (digit <= minDigit)
                    {
                        minDigit = digit;
                        index = i;
                    }
                }
            }
            return index;
        }

        private static long GetMinEvenIndex(List<int> input)
        {
            long index = long.MaxValue;
            int minDigit = int.MaxValue;
            for (int i = 0; i < input.Count; i++)
            {
                int digit = input[i];
                if (digit % 2 == 0)
                {
                    if (digit <= minDigit)
                    {
                        minDigit = digit;
                        index = i;
                    }
                }
            }
            return index;
        }

        private static void MaxElement(string[] tokens, List<int> input)
        {
            string type = tokens[1];
            if(type == "even")
            {
                long evenIndex = GetMaxEvenIndex(input);
                Console.WriteLine(evenIndex != long.MinValue ? $"{evenIndex}" : "No matches");
            }
            else if(type == "odd")
            {
                long oddIndex = GetMaxOddIndex(input);
                Console.WriteLine(oddIndex != long.MinValue ? $"{oddIndex}" : "No matches");
            }
        }

        private static long GetMaxOddIndex(List<int> input)
        {
            long index = long.MinValue;
            int maxDigit = int.MinValue;
            for (int i = 0; i < input.Count; i++)
            {
                int digit = input[i];
                if(digit % 2 != 0)
                {
                    if (digit >= maxDigit)
                    {
                        maxDigit = digit;
                        index = i;
                    }
                }
            }
            return index;
        }

        private static long GetMaxEvenIndex(List<int> input)
        {
            long index = long.MinValue;
            int maxDigit = int.MinValue;
            for (int i = 0; i < input.Count; i++)
            {
                int digit = input[i];
                if(digit % 2 == 0)
                {
                    if(digit >= maxDigit)
                    {
                        maxDigit = digit;
                        index = i;
                    }
                }
            }
            return index;
        }

        private static void ExchangeArray(string[] tokens, ref List<int> input)
        {
            int index = int.Parse(tokens[1]);
            if (index < 0 || index >= input.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                IEnumerable<int> firstExchange = input.Take(index + 1);
                IEnumerable<int> lastExchange = input.Skip(index + 1);
                input = lastExchange.Concat(firstExchange).ToList();
            }           
        }
    }
}
