using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battles
    {
        static void Main()
        {
            var firstPlayer = int.Parse(Console.ReadLine());
            var secondPlayer = int.Parse(Console.ReadLine());
            var maxBattle = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 1; i <= firstPlayer; i++)
            {
                for (int c = 1; c <= secondPlayer; c++)
                {
                    count++;
                    Console.Write($"({i} <-> {c}) ");
                    if(count == maxBattle)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}
