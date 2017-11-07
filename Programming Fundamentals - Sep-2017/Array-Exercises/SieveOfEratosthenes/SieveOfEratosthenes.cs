using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            var numberRange = int.Parse(Console.ReadLine());
            if (numberRange > 1)
            {
                bool[] arr = new bool[numberRange + 1];
                for (int i = 2; i < arr.Length; i++)
                {
                    arr[i] = true;
                }
                for (int p = 2; p <= Math.Sqrt(numberRange); p++)
                {
                    if (arr[p] == true)
                    {
                        for (int j = p * 2; j <= numberRange; j = j + p)
                        {                    
                             arr[j] = false;
                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == true)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }          
        }
    }
}
