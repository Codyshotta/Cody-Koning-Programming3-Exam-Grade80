using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class PayingPlayer : Player
    {
        double bonusProgressionMultiplier;
        public PayingPlayer(string name, Lane lane, double progression,double multiplier) : base(name, lane, progression)
        {
            this.bonusProgressionMultiplier = multiplier;
        }
        public override int ComputeScore()
        {
            double extraScore = progression * bonusProgressionMultiplier;
            return base.ComputeScore() + Convert.ToInt32(extraScore);
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nProgression multiplier = {bonusProgressionMultiplier}";
        }
    }
}
