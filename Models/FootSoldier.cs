using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class FootSoldier : IranianAgent
    {
        public FootSoldier()
        : base(SensorFactory.CreatePattern(new[] { "thermal" }, 2), AgentRank.FootSoldier)
        { }
    }
    
     
}
