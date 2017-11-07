using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            var dataResource = new Dictionary<string, double>();
            File.WriteAllText("..\\..\\output.txt", string.Empty);

            var input = File.ReadAllLines("..\\..\\input.txt");
            for (int i = 0; i < input.Length; i+= 2)
            {            
                string mineResource = input[i];
                if(mineResource == "stop")
                {
                    break;
                }
                double quantity = double.Parse(input[i + 1]);
                if (!dataResource.ContainsKey(mineResource))
                {
                    dataResource.Add(mineResource, 0);
                }
                dataResource[mineResource] += quantity;
            }
            
            foreach (var res in dataResource)
            {
                string result = $"{res.Key} -> {res.Value}" + Environment.NewLine;
                File.AppendAllText("..\\..\\output.txt", result);
            }
        }
    }
}
