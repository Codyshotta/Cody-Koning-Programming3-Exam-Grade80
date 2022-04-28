using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    abstract class Pickup
    {
        float progression;
        Lane lane;
        public Pickup(float progression, Lane lane)
        {
            this.progression = progression;
            this.lane = lane;
        }
    }
}
