using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Icarus
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            int startPosition = int.Parse(Console.ReadLine());
            int pos = startPosition;
            int damage = 1;
            string commands;
            while ((commands = Console.ReadLine()) != "Supernova")
            {
                string[] tokens = commands.Split(' ');
                string direction = tokens[0];
                int step = int.Parse(tokens[1]);
                                
                if(direction == "right")
                {                   
                    while (step > 0)
                    {
                        pos++;
                        if (pos > sequence.Length - 1)
                        {
                            damage++;
                            pos = 0;
                        }                       
                        sequence[pos] -= damage;                       
                        step--;
                    }
                }
                else if(direction == "left")
                {
                    while(step > 0)
                    {
                        pos--;
                        if (pos < 0)
                        {
                            damage++;
                            pos = sequence.Length - 1;
                        }
                        sequence[pos] -= damage;                   
                        step--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
