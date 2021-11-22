using System;

namespace FightSim2
{
    public class Weapon
    {
        public string name;
        static Random rng = new Random();
        public virtual void Attack(Fighter target)
        {
            int dmg;

            if (rng.Next(1, 21) == 20)
            {
                dmg = rng.Next(15, 25);
                Console.WriteLine($"{dmg} DMG : CRITCAL HIT!");
                target.hp -= dmg;
            }
            else
            {
                dmg = rng.Next(5, 10);
                Console.WriteLine($"{dmg} DMG : Normal attack \n");

                target.hp -= dmg;
            }
        }
    }
}