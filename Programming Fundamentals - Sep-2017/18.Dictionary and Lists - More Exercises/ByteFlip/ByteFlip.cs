using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ByteFlip
{
    class ByteFlip
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Reverse()
                .Select(x => x.ToCharArray().Reverse().ToArray())
                .Select(e => string.Join("", e).ToString())
                .Select(crypt => (char)(Convert.ToInt32(crypt, 16)))
                .ToArray();

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
