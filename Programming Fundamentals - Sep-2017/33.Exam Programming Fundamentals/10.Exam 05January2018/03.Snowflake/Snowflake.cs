using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Snowflake
    {
        static void Main()
        {
            string patternSurface = @"^[^A-Za-z0-9]+$";
            string patternMantle = @"^[0-9_]+$";
            string patternCore = @"^([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";

            var surface1 = Console.ReadLine();
            var mantle1 = Console.ReadLine();
            var core = Console.ReadLine();
            var mantle2 = Console.ReadLine();
            var surface2 = Console.ReadLine();

            Match matchedSurface1 = Regex.Match(surface1, patternSurface);
            Match matchedMantle1 = Regex.Match(mantle1, patternMantle);
            Match matchedCore = Regex.Match(core, patternCore);
            Match matchedMantle2 = Regex.Match(mantle2, patternMantle);
            Match matchedSurface2 = Regex.Match(surface2, patternSurface);

            if (matchedSurface1.Success)
            {
                if (matchedMantle1.Success)
                {
                    if (matchedCore.Success)
                    {
                        if (matchedMantle2.Success)
                        {
                            if (matchedSurface2.Success)
                            {
                                int length = matchedCore.Groups[3].Length;
                                Console.WriteLine("Valid");
                                Console.WriteLine(length);
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
