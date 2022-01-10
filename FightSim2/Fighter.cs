using System;
using System.Collections.Generic;


namespace FightSim2
{
    public class Fighter
    {

        // Ser till att allt är antingen protected eller public så att dem kan användas i Opponent

        protected string name;

        public int hp;

        protected static Random rng = new Random();

        public Weapon weapon = new Gun();

        public List<Weapon> weapons = new List<Weapon>();

        public Fighter()
        {
            hp = rng.Next(80, 100);
            SetName();
            weapons.Add(new Gun());
            weapons.Add(new Sword());
        }

        public void SetName()
        {
            Console.WriteLine("Whats your name!");
            name = Console.ReadLine();
        }

        public string GetName()
        {
            return name;
        }

        public void SetHP()
        {

        }

        public virtual void Attack(Fighter opponent)
        {
            int weaponChoice = -1;

            Console.WriteLine("Which weapon would you like to draw on your opponent? (Sword [1] || Gun [2]");


            // Den här while loopen kollar vilket vapen som spelaren väljer att använda och ser till att valet är giltigt. Har dessutom gjort det så att om spelaren väljer att skriva "2", då ska programmet läsa av det som "1" eftersom att listor börjar med 0 men jag vill att vapenalternativen ska vara 1 och 2 istället för 0 och 1. 

            while (weaponChoice < 0 || weaponChoice >= weapons.Count)
            {
                string whatWeapon = Console.ReadLine();
                bool success = int.TryParse(whatWeapon, out weaponChoice);
                if (success == false)
                {
                    Console.WriteLine("Nej skriv en siffra, dummer!");
                }
                weaponChoice--;
            }

            // Attackmeddelande

            weapons[weaponChoice].Attack(opponent);

            Console.WriteLine($"\n{name} draws his {weapons[weaponChoice].name} at {opponent.GetName()}");
        }
    }
}