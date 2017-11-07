using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main()
        {
            List<string> sequence = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
       
            string[] command = Console.ReadLine().Split(' ');
            while(command[0] != "end")
            {
                string operation = command[0];
                if(operation == "reverse")
                {
                    ReverseArray(sequence, command);
                }
                else if(operation == "sort")
                {
                    SortArray(command, sequence);
                }
                else if(command[0] == "rollLeft")
                {
                    RollLeftArray(command, sequence);
                }
                else if (command[0] == "rollRight")
                {
                    RollRightArray(command, sequence);
                }
    
                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }

        private static void RollRightArray(string[] command, List<string> sequence)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            for (int i = 0; i < count % sequence.Count; i++)
            {
                string element = sequence[sequence.Count - 1];
                sequence.RemoveAt(sequence.Count - 1);
                sequence.Insert(0, element);
            }         
        }

        private static  void RollLeftArray(string[] command, List<string> sequence)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            for (int i = 0; i < count % sequence.Count; i++)
            {
                string element = sequence[0];
                sequence.RemoveAt(0);
                sequence.Add(element);
            }
        }

        private static void SortArray(string[] command, List<string> sequence)
        {
            int count = int.Parse(command[4]);
            int start = int.Parse(command[2]);
            if (start < 0 || count < 0 || start > sequence.Count - 1 || start + count - 1 > sequence.Count - 1)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            var takeSortElements = sequence.Skip(start).Take(count).OrderBy(e => e).ToList();
            sequence.RemoveRange(start, count);
            sequence.InsertRange(start, takeSortElements);
        }

        private static void ReverseArray(List<string> sequence, string[] command)
        {            
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);
            if (start < 0 || count < 0 || start > sequence.Count - 1 || start + count - 1 > sequence.Count - 1)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            var takeReverseElements = sequence.Skip(start).Take(count).Reverse().ToList();
            sequence.RemoveRange(start, count);
            sequence.InsertRange(start, takeReverseElements);          
        }   
    }
}
