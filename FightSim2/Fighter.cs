using System;
using System.Collections.Generic;


namespace FightSim2
{
    public class Fighter
    {
        string name;

        public int hp;

        static Random rng = new Random();

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

        public void Attack(Fighter opponent)
        {
            int i = -1;

            Console.WriteLine("Which weapon would you like to draw on your opponent? (Sword [1] || Gun [2]");

            while (i < 0 || i >= weapons.Count)
            {
                string whatWeapon = Console.ReadLine();
                int.TryParse(whatWeapon, out i);
                i--;
            }



            weapons[i].Attack(opponent);

            Console.WriteLine($"\n{name} draws his {weapons[i].name} at {opponent.GetName()}");
            // opponent.hp -= weapon.Attack();

            // opponent.hp = Math.Max(opponent.hp, 0);
        }
    }
}