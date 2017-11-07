using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    public class Arm
    {
        public long Energy { get; set; }
        public int Reach { get; set; }
        public int Fingers { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Arm:" + Environment.NewLine;
            result += $"###Energy consumption: {Energy}" + Environment.NewLine;
            result += $"###Reach: {Reach}" + Environment.NewLine;
            result += $"###Fingers: {Fingers}" + Environment.NewLine;
            return result;
        }
    }
}
