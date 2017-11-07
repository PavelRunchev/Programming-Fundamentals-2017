using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            int[] firstSequence = File.ReadAllText(@"..\..\FileOne.txt")
                .Split('\n')
                .Select(l => int.Parse(l))
                .ToArray();
            int[] secondSequence = File.ReadAllText(@"..\..\FileTwo.txt")
                .Split('\n')
                .Select(n => int.Parse(n))
                .ToArray();
            string[] resultMerges = firstSequence.Concat(secondSequence)
                .OrderBy(n => n)
                .Select(a => a.ToString())
                .ToArray();
            File.WriteAllText(@"..\..\Result.txt", "");
            File.WriteAllLines(@"..\..\Result.txt", resultMerges);
        }
    }
}
