using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    public class JarvisRobot
    {
        static void Main()
       {
            Jarvis jarvis = new Jarvis();

            long jarvisEnergy = long.Parse(Console.ReadLine());
            jarvis.Energy = jarvisEnergy;

            string input = Console.ReadLine();
            while(input != "Assemble!")
            {
                string[] tokens = input.Split(' ');
                if(tokens[0] == "Head")
                {
                    AddHead(tokens, jarvis);
                }
                else if(tokens[0] == "Torso")
                {
                    AddTorso(tokens, jarvis);             
                }
                else if (tokens[0] == "Arm")
                {
                    AddArm(tokens, jarvis);
                }
                else if(tokens[0] == "Leg")
                {
                    AddLeg(tokens, jarvis);           
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(jarvis.ToString());
        }

        private static void AddLeg(string[] tokens, Jarvis jarvis)
        {
            Leg leg = new Leg();
            long energyLeg = long.Parse(tokens[1]);
            int strength = int.Parse(tokens[2]);
            int speed = int.Parse(tokens[3]);
            leg.Energy = energyLeg;
            leg.Strength = strength;
            leg.Speed = speed;
            if(jarvis.Legs == null)
            {
                jarvis.Legs = new List<Leg>();
            }
            if(jarvis.Legs.Count < 2)
            {
                jarvis.Legs.Add(leg);
            }
            else
            {
                for (int i = 0; i < jarvis.Legs.Count; i++)
                {
                    if(jarvis.Legs[i].Energy > leg.Energy)
                    {
                        jarvis.Legs.RemoveAt(i);
                        jarvis.Legs.Add(leg);
                    }
                }
            }          
        }

        private static void AddArm(string[] tokens, Jarvis jarvis)
        {
            Arm arm = new Arm();
            long energyArm = long.Parse(tokens[1]);
            int reach = int.Parse(tokens[2]);
            int fingers = int.Parse(tokens[3]);
            arm.Energy = energyArm;
            arm.Reach = reach;
            arm.Fingers = fingers;
            if(jarvis.Arms == null)
            {
                jarvis.Arms = new List<Arm>();
            }
            if(jarvis.Arms.Count < 2)
            {
                jarvis.Arms.Add(arm);
            }
            else
            {
                for (int i = 0; i < jarvis.Arms.Count; i++)
                {
                    if (jarvis.Arms[i].Energy > arm.Energy)
                    {
                        jarvis.Arms.RemoveAt(i);
                        jarvis.Arms.Add(arm);
                    }
                }
            }
        }

        private static void AddTorso(string[] tokens, Jarvis jarvis)
        {
            Torso torso = new Torso();
            int energyTorso = int.Parse(tokens[1]);
            double processorTorso = double.Parse(tokens[2]);
            string corpusTorso = tokens[3];
            torso.Energy = energyTorso;
            torso.ProcessorSize = processorTorso;
            torso.Material = corpusTorso;
            if(jarvis.Torso == null)
            {
                jarvis.Torso = torso;
            }
            if (jarvis.Torso.Energy > torso.Energy)
            {
                jarvis.Torso = torso;
            }
        }

        private static void AddHead(string[] tokens, Jarvis jarvis)
        {
            Head head = new Head();
            int eneregyHead = int.Parse(tokens[1]);
            int iqHead = int.Parse(tokens[2]);
            string materialHead = tokens[3];
            head.Energy = eneregyHead;
            head.Iq = iqHead;
            head.Material = materialHead;
            
            if(jarvis.Head == null)
            {
                jarvis.Head = head;
            }
            if (jarvis.Head.Energy > head.Energy)
            {
                jarvis.Head = head;
            }
        }
    }
}
