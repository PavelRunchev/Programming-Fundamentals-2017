using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var m = long.Parse(Console.ReadLine());
            var exhaustionFactor = long.Parse(Console.ReadLine());

            long power = n;
            double equal = (n * 0.5);
            long target = 0;
            while (power >= m)
            {
                power -= m;
                if (power == equal)
                {
                    if (exhaustionFactor > 0)
                    {
                        power /= exhaustionFactor;
                    }
                }
                target++;
            }
            Console.WriteLine(power);
            Console.WriteLine(target);
        }
    }
}
