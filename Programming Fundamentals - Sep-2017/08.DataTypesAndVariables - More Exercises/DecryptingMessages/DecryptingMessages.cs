using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLine = int.Parse(Console.ReadLine());

            StringBuilder message = new StringBuilder();
            for (int i = 0; i < numberOfLine; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                message.Append((char)((int)letter + key));
            }
            Console.WriteLine(message);
        }
    }
}
