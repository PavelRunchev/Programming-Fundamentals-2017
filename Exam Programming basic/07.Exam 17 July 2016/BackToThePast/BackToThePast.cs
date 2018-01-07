﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main()
        {
            var inheritedMoney = decimal.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var age = 18;
            for (int i = 1800; i <= year; i++)
            {               
                if(i % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }
                if(i % 2 != 0)
                {
                    inheritedMoney -= 12000 + (50 * age);
                }
                age++;
            }
            if(inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}
