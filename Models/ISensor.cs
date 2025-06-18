using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal interface ISensor
    {
        string Name { get; }
        bool Activate(ISensor weakness);
    }
}
