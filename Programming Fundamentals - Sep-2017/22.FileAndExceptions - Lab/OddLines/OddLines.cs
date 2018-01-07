using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            string[] file = File.ReadAllText(@"..\..\Input.txt")
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var oddLineFiles = file.Where((i, index) => index % 2 != 0).ToArray();
            Console.WriteLine(string.Join("\n", oddLineFiles));
        }
    }
}
