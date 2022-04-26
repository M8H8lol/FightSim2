using System;

namespace FightSim2
{
    public class Longsword : Sword
    {
        // Creating an inheretence to Sword called Longsword
        public Longsword()
        {
            name = "Longsword";
            minDamage = 15;
            maxDamage = 20;
            minCritDamage = 30;
            maxCritDamage = 35;

            noDamage = 0;
        }
    }
}