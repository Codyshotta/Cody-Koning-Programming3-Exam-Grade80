using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class Team
    {
        public readonly List<Player> players;
        readonly string name;
        DateTime GameTime { get; set; }

        public string Name { get { return name; }}
        public int TotalScore { 
            get
            {
                int totalScore = 0;
                foreach (Player player in players)
                {
                    totalScore += player.ComputeScore();
                }
                return totalScore;
            } 
        }
        public Team(string name, DateTime gameTime)
        {
            this.name = name;
            this.GameTime = gameTime;
            players = new List<Player>();
        }
    }
}
