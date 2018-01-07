using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Operation
    {
        static void Main()
        {
            var N1 = int.Parse(Console.ReadLine());
            var N2 = int.Parse(Console.ReadLine());
            var operand = Console.ReadLine();
            var typeNumber = string.Empty;
            var result = 0;
            switch(operand)
            {
                case "+": result = N1 + N2; break;
                case "-": result = N1 - N2; break;
                case "*": result = N1 * N2; break;
            }
            if(result != 0)
            {
                if (result % 2 == 0)
                    typeNumber = "even";
                else
                    typeNumber = "odd";
                Console.WriteLine($"{N1} {operand} {N2} = {result} - {typeNumber}");
                return;
            }
            if(operand == "/")
            {
                if(N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                    return;
                }
                var divide = (double)N1 / (double)N2;
                Console.WriteLine($"{N1} {operand} {N2} = {divide:f2}");
            }
            if(operand == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                    return;
                }
                result = N1 % N2;
                Console.WriteLine($"{N1} {operand} {N2} = {result}");
            }
        }
    }
}
