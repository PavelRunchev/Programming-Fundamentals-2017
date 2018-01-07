using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            var countOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger highResult = 0;
            var highSnow = 0;
            var highTime = 0;
            var highQuality = 0;
            for (int i = 0; i < countOfSnowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());
                BigInteger result = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if(result > highResult)
                {
                    highResult = result;
                    highSnow = snowballSnow;
                    highTime = snowballTime;
                    highQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{highSnow} : {highTime} = {highResult} ({highQuality})");
        }
    }
}
