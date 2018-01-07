using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main()
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            Console.WriteLine(r1.Inside(r2) ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            double[] inputParams = Console.ReadLine()
                .Split().Select(double.Parse)
                .ToArray();
      
            return new Rectangle()
            {
                Top = inputParams[1],
                Left = inputParams[0],
                Width = inputParams[2],
                Height = inputParams[3]
            };
        }
    }
}
