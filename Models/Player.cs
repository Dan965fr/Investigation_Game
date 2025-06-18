using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal class Player
    {
            public int Score { get; private set; } = 0;

            public void AddScore(int points)
            {
                Score += points;
            }

            public string GetRank()
            {
                if (Score < 5) return "Rookie";
                if (Score < 10) return "Investigator";
                if (Score < 20) return "Agent";
                return "Elite Detective";
            }

            public override string ToString()
            {
                return $"Score: {Score}, Rank: {GetRank()}";
            }
        

    }
}
