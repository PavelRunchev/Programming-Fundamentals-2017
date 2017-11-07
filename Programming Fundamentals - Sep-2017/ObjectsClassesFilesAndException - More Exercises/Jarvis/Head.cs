using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    public class Head
    {
        public int Energy { get; set; }
        public int Iq { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Head:" + Environment.NewLine;
            result += $"###Energy consumption: {Energy}" + Environment.NewLine;
            result += $"###IQ: {Iq}" + Environment.NewLine;
            result += $"###Skin material: {Material}" + Environment.NewLine;
            return result;
        }
    }
}
