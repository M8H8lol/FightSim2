using System;

namespace FightSim2
{
    public class Fighter
    {
        string name;

        public int hp;

        static Random rng = new Random();

        public Weapon weapon = new Weapon();

        public Fighter()
        {
            hp = rng.Next(80, 100);
            SetName();
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
            Console.WriteLine($"\n{name} swings his sword at {opponent.GetName()}");
            opponent.hp -= weapon.Attack();

            opponent.hp = Math.Max(opponent.hp, 0);
        }
    }
}