using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class MotionSensor:ISensor
    {
        public string Name { get; set; }
        private int _activationsLeft = 3;

        public MotionSensor()
        {
            Name = "motion";
        }

        public bool Activate(ISensor weakness)
        {
            if (_activationsLeft <= 0)
            {
                Console.WriteLine("MotionSensor is broken");
                return false;
            }

            _activationsLeft--;
            return Name == weakness.Name;
        }

        public override string ToString()
        {
            return $"{Name} (uses left: {_activationsLeft})";
        }
    }
}
