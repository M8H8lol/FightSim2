using System;

namespace FightSim2
{
    public class Sword : Weapon 
    {
        public Sword()
        {
            name = "Sword";
            minDamage = 5;
            maxDamage = 10;
            minCritDamage = 20;
            maxCritDamage = 25;

            noDamage = 0;
        }
    }
}