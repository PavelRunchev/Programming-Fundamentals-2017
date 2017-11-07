using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class BoatSimulator
    {
        static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int numberOfLine = int.Parse(Console.ReadLine());

            int moveFirstBoat = 0;
            int moveSecondBoat = 0;
            for (int i = 0; i < numberOfLine; i++)
            {
                string move = Console.ReadLine();
                int moved = move.Length;
                if (i % 2 == 0)
                {
                    moveFirstBoat += moved;
                }
                else if (i % 2 != 0)
                {
                    moveSecondBoat += moved;
                }

                if (move == "UPGRADE")
                {
                    firstBoat = (char)((int)firstBoat + 3);
                    secondBoat = (char)((int)secondBoat + 3);
                }

                if (moveFirstBoat >= 50)
                {
                    Console.WriteLine(firstBoat);
                    return;
                }
                if (moveSecondBoat >= 50)
                {
                    Console.WriteLine(secondBoat);
                    return;
                }
            }

            Console.WriteLine(moveFirstBoat > moveSecondBoat ? firstBoat : secondBoat);
        }
    }
}
