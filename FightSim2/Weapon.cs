using System;

namespace FightSim2
{
    public class Weapon
    {
        public string name;
        static Random rng = new Random();


        // Sätter alla damage integers (både vanliga och crit) till 0 så att jag kan anpassa det i subklasserna
        protected int minDamage = 0;
        protected int maxDamage = 0;

        protected int minCritDamage = 0;
        protected int maxCritDamage = 0;



        public void Attack(Fighter target)
        {
            int dmg;

            if (rng.Next(1, 21) == 20)
            {
                dmg = rng.Next(minCritDamage, maxCritDamage);
                Console.WriteLine($"{dmg} DMG : CRITCAL HIT!");
                target.hp -= dmg;
            }
            else
            {
                dmg = rng.Next(minDamage, maxDamage);
                Console.WriteLine($"{dmg} DMG : Normal attack \n");

                target.hp -= dmg;
            }
        }
    }
}