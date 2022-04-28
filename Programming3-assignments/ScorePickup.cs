using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    abstract class ScorePickup : Pickup
    {
        int score;
        public ScorePickup(float progression, Lane lane, int score) : base(progression, lane)
        {
            this.score = score;
        }
    }
}
