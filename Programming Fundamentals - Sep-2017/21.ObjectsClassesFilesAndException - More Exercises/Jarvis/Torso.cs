using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    public class Torso
    {
        public int Energy { get; set; }
        public double ProcessorSize { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Torso:" + Environment.NewLine;
            result += $"###Energy consumption: {Energy}" + Environment.NewLine;
            result += $"###Processor size: {ProcessorSize:f1}" + Environment.NewLine;
            result += $"###Corpus material: {Material}" + Environment.NewLine;
            return result;
        }
    }
}
