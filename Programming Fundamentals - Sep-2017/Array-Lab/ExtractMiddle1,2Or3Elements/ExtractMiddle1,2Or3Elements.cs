using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddle1_2Or3Elements
{
    class ExtractMiddle1_2Or3Elements
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split();

            if(sequence.Length == 1)
            {
                Console.Write("{");
                Console.Write($" {sequence[0]} ");
                Console.WriteLine("}");
                return;
            }
            int getElements = sequence.Length % 2 == 0 ? 2 : 3;
            int startIndex = sequence.Length / 2 - 1;
            List<string> middleList = new List<string>();
            for (int i = startIndex; i < startIndex + getElements; i++)
            {
                middleList.Add(sequence[i]);
            }
            Console.Write("{ ");
            Console.Write(string.Join(", ", middleList));
            Console.WriteLine(" }");       
        }
    }
}
