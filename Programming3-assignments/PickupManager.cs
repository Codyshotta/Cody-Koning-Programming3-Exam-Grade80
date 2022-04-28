using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class PickupManager
    {
        List<Pickup> pickups;
        List<Pickup> allPickups;
        List<Player> allPlayers;
        public PickupManager()
        {
            pickups = new List<Pickup>();
            for (int i = 0; i < 5; i++)
            {
                pickups.Add(GeneratePickup());
            }
            allPickups = new List<Pickup>();
            allPlayers = new List<Player>();
        }
        private Pickup GeneratePickup()
        {
            Random generator = new Random();
            switch (generator.Next(0,3))
            {
                case 0:
                    CoinPickup coinpickup = new CoinPickup(generator.Next(10, 101), (Lane)generator.Next(0, 3), generator.Next(10, 50));
                    return coinpickup;
                case 1:
                    DiamondPickup diamondPickup = new DiamondPickup(generator.Next(10, 101), (Lane)generator.Next(0, 3), generator.Next(10, 50));
                    return diamondPickup;
                case 2:
                    SpeedBoostPickup speedBoostPickup = new SpeedBoostPickup(generator.Next(10, 101), (Lane)generator.Next(0, 3));
                    return speedBoostPickup;
            }
            return null;
        }
        public void DisplayPickupAssignments()
        {
            for (int i = 0; i < allPlayers.Count; i ++)
            {
                Console.WriteLine($"{allPickups[i].GetType().Name} assigned to player {allPlayers[i].Name}");
            }
        }
        public void AssignPickupToPlayer(Player player)
        {
            allPickups.Add(pickups[0]);
            allPlayers.Add(player);
            player.AddPickup(pickups[0]);
            pickups.Remove(pickups[0]);
            pickups.Add(GeneratePickup());
        }
    }
}
