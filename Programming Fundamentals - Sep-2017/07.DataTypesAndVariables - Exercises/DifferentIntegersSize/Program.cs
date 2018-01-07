using System;
using System.Collections.Generic;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main()
        {
            List<string> dataTypes = new List<string>();
            string input = Console.ReadLine();
            bool isPrimitive = false;
            sbyte num1;
            if(sbyte.TryParse(input, out num1))
            {
                isPrimitive = true;
                dataTypes.Add("sbyte");
            }
            byte num2;
            if(byte.TryParse(input, out num2))
            {
                isPrimitive = true;
                dataTypes.Add("byte");
            }
            short num3;
            if(short.TryParse(input, out num3))
            {
                isPrimitive = true;
                dataTypes.Add("short");
            }
            ushort num4;
            if (ushort.TryParse(input, out num4))
            {
                isPrimitive = true;
                dataTypes.Add("ushort");
            }
            int num5;
            if (int.TryParse(input, out num5))
            {
                isPrimitive = true;
                dataTypes.Add("int");
            }
            uint num6;
            if (uint.TryParse(input, out num6))
            {
                isPrimitive = true;
                dataTypes.Add("uint");
            }
            long num7;
            if (long.TryParse(input, out num7))
            {
                isPrimitive = true;
                dataTypes.Add("long");
            }

            if(isPrimitive)
            {
                Console.WriteLine($"{input} can fit in:");
                for (int i = 0; i < dataTypes.Count; i++)
                {
                    Console.WriteLine($"* {dataTypes[i]}");
                }
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
