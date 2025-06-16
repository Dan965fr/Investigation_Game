using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class SquadLeader:IranianAgent
    {
        public SquadLeader() : base(new List<ISensor>
        {
            new BasicSensor("thermal"),
            new BasicSensor("movement"),
            new BasicSensor("thermal"),
            new BasicSensor("movement")
        }, AgentRank.SquadLeader) { }

        public override void CounterAttack(int turnNumber)
        {
            if(turnNumber % 3 == 0 && GetAttachSensors().Any())
            {
                var rnd = new Random();
                int index = rnd.Next(GetAttachSensors().Count);
                Console.WriteLine(" Counterattack: A sensor was removed!");
                GetAttachSensors().RemoveAt(index);
            }
        }

    }
}
 