using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class LocalElections
    {
        static void Main()
        {
            var numberOfCandidateLists = int.Parse(Console.ReadLine());
            var voteOfElector = int.Parse(Console.ReadLine());
            var symbol = Console.ReadLine().ToUpper();
            var n = string.Empty;
            for (int i = 1; i <= numberOfCandidateLists; i++)
            {
                if(i < 10)
                {
                    n = "0";
                }
                if(i == voteOfElector)
                {
                    if(symbol == "x" || symbol == "X")
                    {
                        Console.WriteLine(".............");
                        Console.WriteLine("...+-----+...");
                        Console.WriteLine("...|.\\./.|...");
                        Console.WriteLine($"{n}{i}.|..{symbol}..|...");
                        Console.WriteLine("...|./.\\.|...");
                        Console.WriteLine("...+-----+...");
                    }
                    if(symbol == "V" || symbol == "v")
                    {
                        Console.WriteLine(".............");
                        Console.WriteLine("...+-----+...");
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine($"{n}{i}.|.\\./.|...");
                        Console.WriteLine($"...|..{symbol}..|...");
                        
                        Console.WriteLine("...+-----+...");
                    }             
                }
                else
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    for (int c = 1; c <= 3; c++)
                    {
                        if(c == 2)
                        {
                            Console.WriteLine($"{n}{i}.|.....|...");
                        }
                        else
                        {
                            Console.WriteLine("...|.....|...");
                        }                     
                    }
                    Console.WriteLine("...+-----+...");

                }
                n = string.Empty;
            }
            Console.WriteLine(".............");
        }
    }
}
