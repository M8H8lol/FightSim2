using System;

namespace FightSim2
{
    public class Gun : Weapon
    {

        public Gun()
        {
            name = "Gun";
        }
        public override void Attack(Fighter target)
        {
            target.hp -= 100;
        }
    }
}