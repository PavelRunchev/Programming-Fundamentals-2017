using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = string.Empty;

            List<int> takeList = input
                .Where(f => char.IsDigit(f))
                .Where((x, index) => index % 2 == 0)
                .Select(n => int.Parse(n.ToString()))
                .ToList();
            List<int> skipList = input
                .Where(f => char.IsDigit(f))
                .Where((x, index) => index % 2 != 0)
                .Select(n => int.Parse(n.ToString()))
                .ToList();
            List<char> tokensList = input
                .Where(f => !char.IsDigit(f))
                .ToList();

            int totalSkip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                int skip = skipList[i];
                int take = takeList[i];
                result += new string(tokensList.Skip(totalSkip).Take(take).ToArray());
                totalSkip += skip + take;
            }
            Console.WriteLine(result);
        }
    }
}
