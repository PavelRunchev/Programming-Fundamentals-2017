using System;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main()
        {
            int numberRange = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numberRange; i++)
            {
                bool isPrime = true;
                for (int devide = 2; devide <= Math.Sqrt(i); devide++)
                {
                    if (i % devide == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
