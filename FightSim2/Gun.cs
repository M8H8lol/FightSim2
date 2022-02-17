using System;

namespace FightSim2
{
    public class Gun : Weapon
    {

        public Gun()
        {
            name = "Gun";
            minDamage = 15;
            maxDamage = 20;
            minCritDamage = 20;
            maxCritDamage = 25;

            noDamage = 0;
        }
    }
}