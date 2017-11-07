using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    public class Jarvis
    {
        public long Energy { get; set; }
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }

        public override string ToString()
        {
            if(Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
            {
                return "We need more parts!";
            }

            long totalEnergy = 0;
            totalEnergy += Head.Energy;
            totalEnergy += Torso.Energy;
            totalEnergy += Arms.Sum(s => s.Energy);
            totalEnergy += Legs.Sum(s => s.Energy);

            if(totalEnergy > Energy)
            {
                return "We need more power!";
            }

            StringBuilder printRobotJarvis = new StringBuilder();
            printRobotJarvis.Append("Jarvis:" + Environment.NewLine);
            printRobotJarvis.Append(Head.ToString());
            printRobotJarvis.Append(Torso.ToString());
            foreach (Arm arm in Arms.OrderBy(a => a.Energy))
            {
                printRobotJarvis.Append(arm.ToString());
            }
            foreach (Leg leg in Legs.OrderBy(l => l.Energy))
            {
                printRobotJarvis.Append(leg.ToString());
            }
            
            return printRobotJarvis.ToString();
        }
    }
}
