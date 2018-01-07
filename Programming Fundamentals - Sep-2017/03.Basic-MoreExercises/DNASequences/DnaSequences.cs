using System;

namespace DNASequences
{
    class DnaSequences
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int l1 = 1; l1 <= 4; l1++)
            {
                for (int l2 = 1; l2 <= 4; l2++)
                {
                    for (int l3 = 1; l3 <= 4; l3++)
                    {                
                        if(l1 + l2 + l3 >= number)
                        {
                            Console.Write("O" + ($"{l1}{l2}{l3}").Replace("1", "A").Replace("2", "C").Replace("3", "G").Replace("4", "T") + "O" + " ");
                        }
                        else
                        {
                            Console.Write("X" + ($"{l1}{l2}{l3}").Replace("1" , "A").Replace("2", "C").Replace("3", "G").Replace("4", "T") + "X" + " ");
                        }
                        count++;
                        if(count == 4)
                        {
                            Console.WriteLine();
                            count = 0;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
