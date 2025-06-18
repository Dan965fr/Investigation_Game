using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class BasicSensor:ISensor
    {
        public string Name {  get; set; }
        public BasicSensor(string name)
        {
            Name = name;
        }
        public bool Activate(ISensor weakness)
        {
            return Name == weakness.Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
