using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long element;
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Delete":
                        element = long.Parse(command[1]);
                        DeletedAllElementsEqualOfElement(numbers, element);
                            break;
                    case "Insert":
                        element = long.Parse(command[1]);
                        int position = int.Parse(command[2]);                  
                        numbers.Insert(position, element); break;
                    case "Odd":
                        numbers = numbers.Where(num => num % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", numbers));
                        return;
                    case "Even":
                        numbers = numbers.Where(num => num % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ", numbers));
                        return;
                }
            }          
        }

        private static void DeletedAllElementsEqualOfElement(List<long> numbers, long element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == element)
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }
        }
    }
}
