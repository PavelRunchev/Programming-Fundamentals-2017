using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb1 = int.Parse(Console.ReadLine());
            var numb2 = int.Parse(Console.ReadLine());
            var numb3 = int.Parse(Console.ReadLine());


            if (numb1 == numb2 && numb1 == numb3)
            {
                
              Console.WriteLine("yes");
            }
            else
            if (numb1 != numb2 || numb1 != numb3)
            {

                Console.WriteLine("no");

            }
            

        }
    }
}
