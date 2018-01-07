using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            string res = null;
            string answer = null;
            for (int i = 1; i <= N; i++)
            {
                uint num = uint.Parse(Console.ReadLine());
                
                if(num % 4 == 0)
                {
                    A++;
                    answer = "a";
                    
                }
                else if(num % 4 == 1)
                {
                    B++;
                    answer = "b";
                    
                }
                else if(num % 4 == 2)
                {
                    C++;
                    answer = "c";
                    
                }
                else if(num % 4 == 3)
                {
                    D++;
                    answer = "d";
                    
                }
                res += answer + " ";
            }
            Console.WriteLine(res);
            Console.WriteLine($"Answer A: {A}");
            Console.WriteLine($"Answer B: {B}");
            Console.WriteLine($"Answer C: {C}");
            Console.WriteLine($"Answer D: {D}");
        }
    }
}
