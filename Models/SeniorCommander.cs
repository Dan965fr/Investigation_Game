using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class SeniorCommander : IranianAgent,ICounterAttackable
    {
        public SeniorCommander()
       : base(SensorFactory.CreatePattern(new[] { "thermal", "movement" }, 3), AgentRank.SeniorCommander)
        { }

        public  void CounterAttack(int turnNumber)
        {
            if(turnNumber % 3  == 0 && GetAttachSensors().Any())
            {
                var rnd = new Random();
                for(int i = 0;i < 2 && GetAttachSensors().Any(); i++)
                {
                    int index = rnd.Next(GetAttachSensors().Count);
                    GetAttachSensors().RemoveAt(index);


                }
                Console.WriteLine("Counterattack (Senior Commander): 2 sensors were removed!");
            }
        }

    }
}
