using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class OrganizationLeader : IranianAgent,ICounterAttackable
    {
        public OrganizationLeader() :  base(
        SensorFactory.CreatePattern(new[] { "thermal", "movement" }, 4),
        AgentRank.OrganizationLeader)
        { }


        public   void CounterAttack(int turnNumber)
        {
            if(turnNumber % 3 == 0 && GetAttachSensors().Any())
            {
                var rnd = new Random();
                int index = rnd.Next(GetAttachSensors().Count);
                GetAttachSensors().RemoveAt(index);
                Console.WriteLine("Counterattack (Org Leader - every 3 turns): 1 sensor removed");
            }
            if (turnNumber % 10 == 0)
            {
                _attachedSensors.Clear(); // Remove all sensors
                Console.WriteLine("Counterattack (Org Leader - every 10 turns): All sensors removed");
              
            }
        }
    }
}
