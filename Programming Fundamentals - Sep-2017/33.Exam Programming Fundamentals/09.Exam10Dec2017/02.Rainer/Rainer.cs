using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Rainer
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int donald = input[input.Count - 1];
            input.RemoveAt(input.Count - 1);
            List<int> field = new List<int>(input);
            field = DecreaseField(field);

            int steps = 0;
            if(field[donald] != 0)
            {
                while (true)
                {             
                    donald = int.Parse(Console.ReadLine());
                    steps++;
                    field = DecreaseField(field);
                    if (field[donald] == 0)
                    {
                        break;
                    }
                    field = CheckForZeroElement(field, input);
                    
                }
            }
            

            Console.WriteLine(string.Join(" ", field));
            Console.WriteLine(steps);
        }

        private static List<int> CheckForZeroElement(List<int> field, List<int> input)
        {
            for (int i = 0; i < field.Count; i++)
            {
                if(field[i] == 0)
                {
                    field[i] = input[i];
                }
            }
            return field;
        }

        private static List<int> DecreaseField(List<int> field)
        {
            for (int i = 0; i < field.Count; i++)
            {
                if(field[i] > 0)
                {
                    field[i]--;
                }
            }

            return field;
        }
    }
}
