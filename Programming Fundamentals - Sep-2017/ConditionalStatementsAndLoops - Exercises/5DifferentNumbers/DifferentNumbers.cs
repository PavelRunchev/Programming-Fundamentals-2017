﻿using System;

namespace DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            bool isCombination = false;

            for (int n1 = a; n1 <= b; n1++)
            {
                for (int n2 = a; n2 <= b; n2++)
                {
                    for (int n3 = a; n3 <= b; n3++)
                    {
                        for (int n4 = a; n4 <= b; n4++)
                        {
                            for (int n5 = a; n5 <= b; n5++)
                            {
                                if (a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    isCombination = true;
                                }                           
                            }
                        }
                    }
                }
            }
            if (!isCombination)
            {
                Console.WriteLine("No");
            }
        }
    }
}
