using System;

namespace FightSim2
{
    public class Gun : Weapon
    {

        // Giving Gun its own damage values that was inherited from the values from Weapon
        public Gun()
        {
            Name = "Gun";
            minDamage = 15;
            maxDamage = 20;
            minCritDamage = 20;
            maxCritDamage = 25;

            noDamage = 0;
        }
    }
}