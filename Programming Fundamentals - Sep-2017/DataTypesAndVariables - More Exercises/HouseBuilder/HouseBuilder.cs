using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class HouseBuilder
    {
        static void Main()
        {
            int firstPrice = int.Parse(Console.ReadLine());
            int secondPrice = int.Parse(Console.ReadLine());

            sbyte sbyteValue;
            int intValue;
            int sumSbyte = 0;
            long sumInt = 0;           
            int minValue = Math.Min(firstPrice, secondPrice);
            int maxValue = Math.Max(firstPrice, secondPrice);

            if(sbyte.TryParse(minValue.ToString(), out sbyteValue))
            {
                sumSbyte = (int)(sbyteValue) * 4;
            }
            if(int.TryParse(maxValue.ToString(), out intValue))
            {
                sumInt = (long)intValue * 10;
            }
            Console.WriteLine(sumInt + (long)sumSbyte);
        }
    }
}
