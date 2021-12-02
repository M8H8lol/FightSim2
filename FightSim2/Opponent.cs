using System;
using System.Collections.Generic;


namespace FightSim2
{

    // Inte klar
    public class Opponent : Fighter
    {


        public override void Attack(Fighter target)
        {
            weapons[0].Attack(target);
        }
    }
}