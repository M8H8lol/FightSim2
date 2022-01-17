using System;

namespace FightSim2
{
    public class Gun : Weapon
    {

        public Gun()
        {
            name = "Gun";
            minDamage = 10;
            maxDamage = 15;
            minCritDamage = 15;
            maxCritDamage = 20;

            noDamage = 0;
        }
    }
}