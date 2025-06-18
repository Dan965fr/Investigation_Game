using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class SignalSensor:ISensor
    {
        public string Name { get; set; }

        public SignalSensor()
        {
            Name = "signal";
        }

        public bool Activate(ISensor weakness)
        {
            Console.WriteLine("SignalSensor activated: Revealing agent info... (e.g., rank)");
            return Name == weakness.Name;
        }

        public override string ToString()
        {
            return $"{Name} (reveals 1 info field)";
        }
    }
}
