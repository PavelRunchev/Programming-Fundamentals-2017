using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltAndPepper
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong dishes = ulong.Parse(Console.ReadLine());
            string spice = Console.ReadLine();
            while(spice != "end")
            {
                if (spice == "end")
                {
                    break;
                }
                string[] elements = spice.Split(' ');
                string action = elements[0];
                int step = int.Parse(elements[1]);

                if(action == "salt")
                {
                    for (int i = 0; i <= 63; i+= step)
                    {
                        if(((dishes >> i) & 1) == 1)
                        {
                            ulong mask = ~((ulong)1 << i);
                            dishes = dishes & mask;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= 63; i+= step)
                    {
                        if(((dishes >> i) & 1) == 0)
                        {
                            ulong mask = (ulong)1 << i;
                            dishes = dishes | mask;
                        }
                    }
                }
                spice = Console.ReadLine();
            }
            Console.WriteLine(dishes);       
        }
    }
}
