using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class PluseSensor:ISensor
    {
        public string Name { get; set; }
        private int _activationsLeft = 3;

        public PluseSensor()
        {
            Name = "pluse";
        }
        public bool Activate(ISensor weakness)
        {
            if(_activationsLeft <= 0)
            {
                Console.WriteLine("PluseSensore is broken");
                return false;
            }
            _activationsLeft--;
            return Name == weakness.Name;
        }
        public override string ToString()
        {
            return $"{Name}(user left: {_activationsLeft})";
        }


    }
}
