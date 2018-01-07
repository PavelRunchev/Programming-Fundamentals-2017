using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            //top
            for (int row = 0; row < N; row++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', row), new string('.', 2 * N - 2 * row), new string('.', row * 2));
            }
            //middle
            for (int row = 0; row < N + 1; row++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', 1 + 2 * row), new string('~', N - row), new string('.', 2 * N - 2 * row));
            }
            //bottom
            for (int row = 0; row < N; row++)
            {
                Console.WriteLine("{0}##{0}", new string('.', 2 * N + 2));
            }

        }
    }
}
