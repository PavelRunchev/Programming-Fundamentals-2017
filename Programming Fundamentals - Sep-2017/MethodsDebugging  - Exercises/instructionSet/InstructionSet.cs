using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instructionSet
{
    class InstructionSet
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            long result = 0;
            while (input != "END")
            {
                string[] command = input.Split(' ');
              
                switch (command[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(command[1]);
                            result = ++operandOne;
                            Console.WriteLine(result);
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(command[1]);
                            result = --operandOne;
                            Console.WriteLine(result);
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(command[1]);
                            long operandTwo = long.Parse(command[2]);
                            result = operandOne + operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(command[1]);
                            long operandTwo = long.Parse(command[2]);
                            result = operandOne * operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                }
                
                input = Console.ReadLine();          
            }
        }
    }
}
