using System;

namespace FightSim2
{
    public class Weapon
    {
        static Random rng = new Random();
        public int Attack()
        {
            int dmg;

            if (rng.Next(1, 21) == 20)
            {
                dmg = rng.Next(15, 25);
                Console.WriteLine($"{dmg} DMG : CRITCAL HIT!");
                return dmg;
            }

            dmg = rng.Next(5, 10);
            Console.WriteLine($"{dmg} DMG : Normal attack \n");

            return dmg;
        }
    }
}