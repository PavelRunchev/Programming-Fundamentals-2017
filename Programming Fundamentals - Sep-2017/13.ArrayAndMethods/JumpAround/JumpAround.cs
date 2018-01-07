using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpAround
{
    class JumpAround
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> sumJump = new List<int>();
            int index = 0;
            int jump = array[0];
            while(true)
            {
                if(index + jump <= array.Length - 1)
                {
                    sumJump.Add(jump);
                    index = index + jump;
                    jump = array[index];
                }
                else if(index - jump >= 0)
                {
                    sumJump.Add(jump);
                    index = index - jump;
                    jump = array[index];
                }
                else
                {
                    sumJump.Add(jump);
                    break;
                }
            }
            Console.WriteLine(sumJump.Sum());
        }
    }
}
