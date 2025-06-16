using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class FootSoldier:IranianAgent
    {
        public FootSoldier() : base(new List<ISensor>
    {
        new BasicSensor("thermal"),
        new BasicSensor("thermal")
    }, AgentRank.FootSoldier)
        { }
    }
}
