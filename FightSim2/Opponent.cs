using System;
using System.Collections.Generic;


namespace FightSim2
{

    // Inte klar
    public class Opponent : Fighter
    {


        // Randomizing the weapon that the opponent will choose
        protected override int ChooseWeapon()
        {
            return rng.Next(Weapons.Count);
        }
    }
}