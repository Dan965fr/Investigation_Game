using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game
{
    internal class IranianAgent
    {
        private List<Sensor> _secretWeakness;
        private List<Sensor> _attachedSensor;

        public IranianAgent(List<Sensor> Weakness)
        {
            _secretWeakness = Weakness;
            _attachedSensor = new List<Sensor>();
        }
        public void AttachedSensore(Sensor sensor)
        {
            _attachedSensor.Add(sensor);
        }
        public int ActivateSensor()
        {
            int count = 0;
            for(int i = 0; i < _attachedSensor.Count && i < _secretWeakness.Count; i++)
            {
                if (_attachedSensor[i].Activate(_secretWeakness[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public bool IsExposed()
        {
            return ActivateSensor() == _secretWeakness.Count;
        }


    }

}
