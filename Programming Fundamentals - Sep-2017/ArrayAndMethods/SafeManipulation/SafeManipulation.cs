using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeManipulation
{
    class SafeManipulation
    {
        static void Main()
        {
            string[] inputSequence = Console.ReadLine().Split(' ');

            string command = Console.ReadLine();
            while (command != "END")
            {
                try
                {
                    string[] tokens = command.Split(' ');
                    switch (tokens[0])
                    {
                        case "Distinct": inputSequence = inputSequence.Distinct().ToArray(); break;
                        case "Reverse": Array.Reverse(inputSequence); break;
                        case "Replace": inputSequence[int.Parse(tokens[1])] = tokens[2]; break;
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", inputSequence));
                
        }
    }
}
