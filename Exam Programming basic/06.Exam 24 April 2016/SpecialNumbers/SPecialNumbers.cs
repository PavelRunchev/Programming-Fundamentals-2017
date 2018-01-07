using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SPecialNumbers
    {
        static void Main()
        {
            var specialNumbers = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if(specialNumbers % i1 == 0)
                            {
                                if(specialNumbers % i2 == 0)
                                {
                                    if(specialNumbers % i3 == 0)
                                    {
                                        if(specialNumbers % i4 == 0)
                                        {
                                            Console.Write($"{i1}{i2}{i3}{i4} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
