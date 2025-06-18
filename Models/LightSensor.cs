using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class LightSensor:ISensor
    {
        public string Name { get; set; }

        public LightSensor()
        {
            Name = "light";
        }

        public bool Activate(ISensor weakness)
        {
            Console.WriteLine("LightSensor activated: Revealing 2 fields of agent info...");
            return Name == weakness.Name;
        }

        public override string ToString()
        {
            return $"{Name} (reveals 2 info fields)";
        }
    }
}
