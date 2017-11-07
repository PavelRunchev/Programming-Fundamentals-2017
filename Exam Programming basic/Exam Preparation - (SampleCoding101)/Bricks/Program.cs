using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main()
        {
            double x = int.Parse(Console.ReadLine());
            double w = int.Parse(Console.ReadLine());
            double m = int.Parse(Console.ReadLine());          
            Console.WriteLine("{0}", Math.Ceiling(x / (w * m)));
        }
    }
}
