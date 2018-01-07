using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAWord
{
    class MakeAWord
    {
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < numberOfLine; i++)
            {
                text.Append(Console.ReadLine());
            }
            Console.WriteLine($"The word is: {text}");
        }
    }
}
