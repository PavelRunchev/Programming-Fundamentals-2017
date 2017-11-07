using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());

            bool balanced = false;
            bool closeBrackets = false;
            for (int i = 0; i < numberOfLine; i++)
            {
                string input = Console.ReadLine();

                if (input == "(" && balanced == true)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                else if (input == "(")
                {
                    balanced = true;
                    closeBrackets = true;
                }
                else if (input == ")" && balanced == true)
                {
                    balanced = false;
                    closeBrackets = false;
                }
                else if (input == ")" && balanced == false)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }               
            }

            Console.WriteLine(!closeBrackets ? "BALANCED" : "UNBALANCED");
        }
    }
}
