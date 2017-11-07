using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceTheThief
{
    class SentenceTheThief
    {
        static void Main()
        {
            string numeralType = Console.ReadLine();
            var countOfId = int.Parse(Console.ReadLine());
            int divisor = 0;
            long thiefsId = 0;
            var sbyteMax = sbyte.MaxValue;
            var sbyteMin = sbyte.MinValue;
            var intMax = int.MaxValue;
            var intMin = int.MinValue;
            var longMax = long.MaxValue;
            var longMin = long.MinValue;
            for (int i = 0; i < countOfId; i++)
            {
                long id = long.Parse(Console.ReadLine());
                if (numeralType == "sbyte")
                {
                    if(id <= sbyteMax)
                    {
                        if(id > sbyteMin)
                        {
                            sbyteMin = (sbyte)id;
                            thiefsId = sbyteMin;
                        }
                    }
                }
                else if (numeralType == "int")
                {
                    if (id <= intMax)
                    {
                        if (id > intMin)
                        {
                            intMin = (int)id;
                            thiefsId = intMin;
                        }
                    }
                }
                else if(numeralType == "long")
                {
                    if (id <= longMax)
                    {
                        if (id > longMin)
                        {
                            longMin = id;
                            thiefsId = longMin;
                        }
                    }
                }
            }

            if (thiefsId > 0)
            {
                divisor = 127;
            }
            else
            {
                divisor = -128;
            }

            long sentence = (long)Math.Ceiling((decimal)thiefsId / divisor);

            if(sentence == 1)
            {
                Console.WriteLine($"Prisoner with id {thiefsId} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefsId} is sentenced to {sentence} years");
            }
        }
    }
}
