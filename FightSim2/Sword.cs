using System;

namespace FightSim2
{
    public class Sword : Weapon
    {
        public Sword()
        {
            name = "Sword";
        }

        public override void Attack(Fighter target)
        {
            target.hp -= 50;
        }
    }
}