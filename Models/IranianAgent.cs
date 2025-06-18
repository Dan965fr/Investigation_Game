using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal  abstract class IranianAgent
    {
        protected List<ISensor> _secretWeaknesses;
        protected List<ISensor> _attachedSensors;
        protected AgentRank _rank;

        protected IranianAgent(List<ISensor> Weakness, AgentRank rank)
        {
            _secretWeaknesses = Weakness;
            _attachedSensors = new List<ISensor>();
            _rank = rank;
        }
        public AgentRank Rank => _rank;
        
        public void AttachSensor(ISensor sensor)
        {
            _attachedSensors.Add(sensor);
        }
        public virtual int ActivateSensors()
        {
            int count = 0;
            List<ISensor>countedSensors = new List<ISensor>();
            foreach(var weakness in _secretWeaknesses)
            {
                foreach(var attached in _attachedSensors)
                {
                    if(!countedSensors.Contains(attached) && attached.Activate(weakness))
                    {
                       count++;
                        countedSensors.Add(attached);
                        break;
                    }
                   
                    
                }
            }
            return count;
        }
        public bool IsExposed()
        {
            return ActivateSensors() == _secretWeaknesses.Count;
        }
        public  int SecretCount()
        {
            return _secretWeaknesses.Count;
        }
        

        public List<ISensor> GetAttachSensors()
        {
            return _attachedSensors;
        }


    }

}
