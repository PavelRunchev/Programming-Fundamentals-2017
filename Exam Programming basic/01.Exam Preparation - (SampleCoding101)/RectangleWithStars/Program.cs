using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var middle = 0;
            if(n % 2 == 1)
            {
                middle = n;
            }
            else
            {
                middle = n - 1;
            }
            Console.WriteLine(new string('%', 2 * n));
            for (int i = 0; i < middle; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n - 2));
                
                if(i == middle / 2)
                {
                    Console.Write("**");
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write(new string(' ', n - 2));
                Console.Write("%");
                Console.WriteLine();
            }

            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
