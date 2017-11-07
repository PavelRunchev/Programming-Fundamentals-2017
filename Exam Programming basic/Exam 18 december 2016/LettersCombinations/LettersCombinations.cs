using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main()
        {
            var start = char.Parse(Console.ReadLine());
            var end = char.Parse(Console.ReadLine());
            var combination = char.Parse(Console.ReadLine());

            var count = 0;
            for (char l1 = start; l1 <= end; l1++)
            {
                for (char l2 = start; l2 <= end; l2++)
                {
                    for (char l3 = start; l3 <= end; l3++)
                    {                      
                        if(l1 != combination && l2 != combination && l3 != combination)
                        {
                            count++;
                            Console.Write($"{l1}{l2}{l3} ");
                        }                   
                    }
                }
            }
            Console.Write($"{count}");
            Console.WriteLine();
        }
    }
}
