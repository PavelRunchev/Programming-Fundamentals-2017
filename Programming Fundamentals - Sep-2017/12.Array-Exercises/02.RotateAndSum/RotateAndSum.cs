using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sumArr = new int[arr.Count];
            var k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int temp = arr[arr.Count - 1];
                arr.Insert(0, temp);
                arr.RemoveAt(arr.Count - 1);
                for (int c = 0; c < arr.Count; c++)
                {
                    sumArr[c] += arr[c];
                }
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
