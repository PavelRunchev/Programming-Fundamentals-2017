using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            int firstNumebr = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstNumebr, secondNumber);
            int thirdNumber = int.Parse(Console.ReadLine());       
            Console.WriteLine(GetMax(max, thirdNumber));
        }

        private static int GetMax(int firstNumebr, int secondNumber)
        {
            return Math.Max(firstNumebr, secondNumber);
        }
    }
}
