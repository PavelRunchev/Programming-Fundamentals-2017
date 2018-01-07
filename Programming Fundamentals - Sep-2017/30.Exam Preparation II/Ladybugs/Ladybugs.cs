using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {
            var sizeOfField = long.Parse(Console.ReadLine());
            var givenIndexes = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToArray();

            long[] field = new long[sizeOfField];
            AddIndexOfField(field, givenIndexes);

            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            while(commands[0] != "end")
            {
                if(commands.Length == 3)
                {
                    long ladybugIndex = long.Parse(commands[0]);
                    string direction = commands[1];
                    long flyLength = long.Parse(commands[2]);
                    if(ladybugIndex > -1 && ladybugIndex < field.Length)
                    {
                        if (flyLength < 0)
                        {
                            direction = direction == "right" ? "left" : "right";
                            flyLength = Math.Abs(flyLength);
                        }

                        if (direction == "right")
                        {
                            if (field[ladybugIndex] == 1)
                            {
                                FlyRight(field, ladybugIndex, flyLength);
                            }
                        }
                        else if (direction == "left")
                        {
                            if (field[ladybugIndex] == 1)
                            {
                                FlyLeft(field, ladybugIndex, flyLength);
                            }
                        }
                    }     
                }
       
                commands = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static void FlyLeft(long[] field, long ladybugIndex, long flyLength)
        {
            field[ladybugIndex] = 0;
            long fly = ladybugIndex - flyLength;
            while (true)
            {
                if (fly > field.Length - 1 || fly < 0)
                {
                    break;
                }
                if (field[fly] == 1)
                {
                    fly = fly - flyLength;
                    continue;
                }
                else
                {
                    field[fly] = 1;
                    break;
                }
            }
        }

        private static void FlyRight(long[] field, long ladybugIndex, long flyLength)
        {
            field[ladybugIndex] = 0;
            long fly = flyLength + ladybugIndex;
            while (true)
            {
                if (fly > field.Length - 1 || fly < 0)
                {
                    break;
                }
                if (field[fly] == 1)
                {
                    fly = fly + flyLength;
                    continue;
                }
                else
                {
                    field[fly] = 1;
                    break;
                }             
            }            
        }

        private static void AddIndexOfField(long[] field, long[] givenIndexes)
        {
            for (long i = 0; i < givenIndexes.Length; i++)
            {
                long addIndex = givenIndexes[i];
                for (long c = 0; c < field.Length; c++)
                {
                    if(c == addIndex)
                    {
                        field[c] = 1;
                    }
                }
            }
        }
    }
}
