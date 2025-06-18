using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class MagneticSensor:ISensor
    {
        public string Name { get; set; }
        private int _deflectsLeft = 2;

        public MagneticSensor()
        {
            Name = "magnetic";
        }

        public bool Activate(ISensor weakness)
        {
            if (_deflectsLeft <= 0)
            {
                Console.WriteLine("MagneticSensor has no deflects left");
                return false;
            }

            if (Name == weakness.Name)
            {
                _deflectsLeft--;
                Console.WriteLine("MagneticSensor successfully deflected a counterattack!");
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Name} (deflects left: {_deflectsLeft})";
        }
    }
}
