using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Snowmen
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            var attackerOrTarget = new List<string>();
            foreach (var item in sequence)
            {
                attackerOrTarget.Add("attacker");
            }

            for (int i = 0; i < attackerOrTarget.Count; i++)
            {
                int atteckerCount = CheckAttacker(attackerOrTarget);
                if(atteckerCount == 1)
                {
                    break;
                }

                int attacker = i;
                if(attackerOrTarget[attacker] == "attacker")
                {
                    int target = sequence[attacker];
                    if (target > attackerOrTarget.Count - 1)
                    {
                        target = target % attackerOrTarget.Count;
                    }

                    int difference = Math.Abs(attacker - target);
                    if(attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        attackerOrTarget[attacker] = "target";
                    }
                    else if(difference % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        attackerOrTarget[target] = "target";
                    }
                    else if(difference % 2 != 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        attackerOrTarget[attacker] = "target";
                    }                   
                }

                if(i == attackerOrTarget.Count - 1)
                {
                    attackerOrTarget = RemoveAttackers(attackerOrTarget, sequence);
                    i = -1;
                }
            }
        }

        private static int CheckAttacker(List<string> attackerOrTarget)
        {
            int count = 0;
            foreach (var item in attackerOrTarget)
            {
                if (item == "attacker")
                    count++;
            }
            return count;
        }

        private static List<string> RemoveAttackers(List<string> attackerOrTarget, List<int> sequence)
        {
            for (int i = 0; i < attackerOrTarget.Count; i++)
            {
                if (attackerOrTarget[i] == "target")
                {
                    attackerOrTarget.RemoveAt(i);
                    sequence.RemoveAt(i);
                    i -= 1;
                }
            }
            return attackerOrTarget;
        }
    }
}
