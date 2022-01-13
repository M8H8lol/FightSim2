using System;
using System.Collections.Generic;


namespace FightSim2
{

    // Inte klar
    public class Opponent : Fighter
    {

        protected override int ChooseWeapon()
        {
            return rng.Next(weapons.Count);
        }
    }
}