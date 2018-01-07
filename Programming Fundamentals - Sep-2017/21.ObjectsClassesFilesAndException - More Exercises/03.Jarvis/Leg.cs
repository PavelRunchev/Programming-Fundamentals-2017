using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    public class Leg
    {
        public long Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Leg:" + Environment.NewLine;
            result += $"###Energy consumption: {Energy}" + Environment.NewLine;
            result += $"###Strength: {Strength}" + Environment.NewLine;
            result += $"###Speed: {Speed}" + Environment.NewLine;
            return result;
        }
    }
}
