using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class CatchTheThief
    {
        static void Main()
        {
            string numeralType = Console.ReadLine();
            var countOfId = int.Parse(Console.ReadLine());
            long thiefsId = 0;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            sbyte maxSbyte = sbyte.MaxValue;
            sbyte minsbyte = sbyte.MinValue;
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            for (int i = 0; i < countOfId; i++)
            {
                long id = long.Parse(Console.ReadLine());
                if(numeralType == "sbyte")
                {
                    
                    if(id <= maxSbyte)
                    {
                        if(id > minsbyte)
                        {
                            minsbyte = (sbyte)id;
                            thiefsId = minsbyte;
                        }
                    }
                }
                else if(numeralType == "int")
                {
                    if(id <= maxInt)
                    {
                        if (id > minInt)
                        {
                            minInt = (int)id;
                            thiefsId = minInt;
                        }
                    }
                }
                else if(numeralType == "long")
                {             
                    if(id <= maxLong)
                    {
                        if(id > minLong)
                        {
                            minLong = id;
                            thiefsId = minLong;
                        }
                    }
                }
            }
            Console.WriteLine(thiefsId);
        }
    }
}
