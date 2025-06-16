using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class IranianAgent
    {
        private List<Sensor> _secretWeaknesses;
        private List<Sensor> _attachedSensors;

        public IranianAgent(List<Sensor> Weakness)
        {
            _secretWeaknesses = Weakness;
            _attachedSensors = new List<Sensor>();
        }
        public void AttachSensor(Sensor sensor)
        {
            _attachedSensors.Add(sensor);
        }
        public int ActivateSensors()
        {
            int count = 0;
            foreach(var attached in _attachedSensors)
            {
                foreach(var weakness in _secretWeaknesses)
                {
                    count++;
                    break;
                }
            }
            return count;
        }
        public bool IsExposed()
        {
            return ActivateSensors() == _secretWeaknesses.Count;
        }
        public int SecretCount()
        {
            return _secretWeaknesses.Count;
        }


    }

}
