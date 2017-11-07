using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());
            List<long> allPimesNumbers = FindPrimesInRange(startNumber, endNumber);

            Console.WriteLine(string.Join(", ", allPimesNumbers));
        }

        private static List<long> FindPrimesInRange(long startNumber, long endNumber)
        {
            var list = new List<long>();
            
            for (long num = startNumber; num <= endNumber; num++)
            {
                bool isPrime = true;
                if (num < 2)
                {
                    isPrime = false;
                    continue;
                }
                isPrime = GetPrimeNumber(num);
                if (isPrime)
                {
                    list.Add(num);
                    isPrime = true;
                }
            }

            return list;
        }

        private static bool GetPrimeNumber(long num)
        {
            for (int d = 2; d <= Math.Sqrt(num); d++)
            {
                if (num % d == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
