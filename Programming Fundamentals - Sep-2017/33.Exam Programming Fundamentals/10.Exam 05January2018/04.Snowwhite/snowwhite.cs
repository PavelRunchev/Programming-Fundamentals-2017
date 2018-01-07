using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
    }
    class snowwhite
    {
        static void Main()
        {
            List<Dwarf> dataDwarfs = new List<Dwarf>();

            string inputDwarfHats;
            while ((inputDwarfHats = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = inputDwarfHats
                    .Split(new string[] { " <:> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string hatColor = tokens[1];
                int physics = int.Parse(tokens[2]);
                if(dataDwarfs.Any(dwarf => dwarf.Name == name && dwarf.HatColor == hatColor))
                {
                    var currentDwarf = dataDwarfs.FirstOrDefault(d => d.Name == name && d.HatColor == hatColor);
                    if(currentDwarf.Physics < physics)
                    {
                        currentDwarf.Physics = physics;
                    }
                }
                else
                {
                    Dwarf dwarf = new Dwarf();
                    dwarf.Name = name;
                    dwarf.HatColor = hatColor;
                    dwarf.Physics = physics;
                    dataDwarfs.Add(dwarf);
                }
            }

            foreach (var dwarf in dataDwarfs.OrderByDescending(a => a.Physics).ThenByDescending(f => f.HatColor.Count()))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }          
        }
    }
}
