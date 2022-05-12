using System;

namespace FightSim2
{
    public class Rifle : Gun
    {

        // Creating an inheretence to Gun called Rifle

        public Rifle()
        {
            Name = "Rifle";
            minDamage = 20;
            maxDamage = 25;
            minCritDamage = 25;
            maxCritDamage = 30;

            noDamage = 0;
        }
    }
}