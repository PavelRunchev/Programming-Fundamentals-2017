using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                
                
            List<int> appendList = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int[] tokens = input[i].Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                appendList.AddRange(tokens);
            }

            Console.WriteLine(string.Join(" ", appendList));
        }
    }
}
