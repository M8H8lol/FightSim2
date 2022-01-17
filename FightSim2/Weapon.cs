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

        protected int noDamage = 0;



        public void Attack(Fighter target)
        {
            int dmg;

            if (rng.Next(1, 11) == 10)
            {
                dmg = rng.Next(minCritDamage, maxCritDamage);
                Console.WriteLine($"CRITCAL HIT! : {dmg} DMG \n");
                target.hp -= dmg;
            }
            else if (rng.Next(1, 11) == 9)
            {
                dmg = rng.Next(noDamage);
                Console.WriteLine($"You missed! : {dmg} DMG \n");
            }
            else
            {
                dmg = rng.Next(minDamage, maxDamage);
                Console.WriteLine($"Normal attack : {dmg} DMG \n");

                target.hp -= dmg;
            }
        }
    }
}