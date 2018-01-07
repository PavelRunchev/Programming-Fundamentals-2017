using System;

namespace TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
