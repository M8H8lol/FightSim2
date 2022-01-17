using System;

namespace FightSim2
{
    public class Sword : Weapon
    {
        public Sword()
        {
            name = "Sword";
            minDamage = 10;
            maxDamage = 15;
            minCritDamage = 20;
            maxCritDamage = 30;

            noDamage = 0;
        }
    }
}