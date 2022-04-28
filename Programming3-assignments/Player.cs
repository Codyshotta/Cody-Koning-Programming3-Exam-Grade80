using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class Player
    {
        protected string name;
        protected Lane lane;
        protected double progression;
        private List<Pickup> pickups;
        public string Name { get { return name; } }
        public Player(string name, Lane lane, double progression)
        {
            this.name = name;
            this.lane = lane;
            this.progression = progression;
            pickups = new List<Pickup>();
        }
        public void AddPickup(Pickup pickup)
        {
            pickups.Add(pickup);
        }
        public virtual int ComputeScore()
        {
            double scoreDouble = Math.Pow(progression, 1.2);
            return (int)scoreDouble;
        }
        public override string ToString()
        {
            return $"{name} on the {lane} lane with a progression of {progression}. score = {ComputeScore()}";
        }
    }
}
