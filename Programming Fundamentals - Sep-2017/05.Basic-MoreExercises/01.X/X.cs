using System;

namespace X
{
    class X
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //upper part
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', (n - 2) - 2 * i));
            }

            //middle part
            Console.WriteLine("{0}x{0}", new string(' ', n / 2));

            //bottom part
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', ((n / 2) - 1) - i), new string(' ', 1 + 2 * i));
            }
        }
    }
}
