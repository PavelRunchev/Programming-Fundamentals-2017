using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateArray
{
    class ManipulateArray
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');
            var numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0] == "Reverse")
                {
                    ReverseArray(array);
                }
                else if (command[0] == "Distinct")
                {
                    array = DistinctArray(array);
                }
                else if(command[0] == "Replace")
                {
                    ReplaceArray(array, command);
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }

        private static void ReplaceArray(string[] array, string[] command)
        {
            int index = int.Parse(command[1]);
            string element = command[2];
            array[index] = element;
        }

        private static string[] DistinctArray(string[] array)
        {
            return array.Distinct().ToArray();
        }

        private static void ReverseArray(string[] array)
        {
            Array.Reverse(array);
        }
    }
}
