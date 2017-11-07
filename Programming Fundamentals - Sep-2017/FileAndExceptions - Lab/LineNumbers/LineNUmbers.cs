using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LineNumbers
{
    class LineNUmbers
    {
        static void Main()
        {
            string[] input = File.ReadAllLines(@"..\..\input.txt");
            var lineNumbersOfInput = input.Select((a, i) => $"{i + 1}. {a}");
            File.WriteAllLines(@"..\..\input.txt", lineNumbersOfInput);
        }
    }
}
