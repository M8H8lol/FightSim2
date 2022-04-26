using System;

namespace FightSim2
{
    public class Sword : Weapon
    {

        // Creating a sword that the fighters can use that inherits its damage values from Weapon
        public Sword()
        {
            name = "Sword";
            minDamage = 10;
            maxDamage = 15;
            minCritDamage = 25;
            maxCritDamage = 30;

            noDamage = 0;
        }
    }
}