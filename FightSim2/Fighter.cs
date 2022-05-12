using System;
using System.Collections.Generic;


namespace FightSim2
{
    public class Fighter
    {


        protected string name;

        // public int Hp { get; set; }

        private int hp;

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp < 0) hp = 0;
            }
        }



        protected static Random rng = new Random();

        private List<Weapon> weapons = new List<Weapon>();

        public List<Weapon> Weapons
        {
            get
            {
                return weapons;
            }
            set
            {
                weapons = value;
            }
        }


        //Creating the fighters, giving them a name depending on the users input and randomizing their HealthPoints (HP) from between 85 and 95 as well as giving them weapons
        public Fighter()
        {
            Hp = rng.Next(85, 95);
            SetName();
            weapons.Add(new Longsword());
            weapons.Add(new Rifle());
        }


        // Giving each of the fighters a name that the user chooses and makes sure they can not write any invalid inputs
        public void SetName()
        {
            while (true)
            {
                Console.WriteLine("Whats your name!");
                name = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Invalid name");
                    Console.WriteLine("Please enter a name that contain letters");
                }
                else
                {
                    break;
                }
            }
        }

        //Creating a method that returns name so I can call it when I want to use their name in my code 
        public string GetName()
        {
            return name;
        }

        // Creating a virtual int method that does the necessary calculations to give the user the weapon they chose
        protected virtual int ChooseWeapon()
        {

            int weaponChoice = -1;

            Console.WriteLine("Which weapon would you like to draw on your opponent? (Longsword [1] || Rifle [2])");


            // Den här while loopen kollar vilket vapen som spelaren väljer att använda och ser till att valet är giltigt. Har dessutom gjort det så att om spelaren väljer att skriva "2", då ska programmet läsa av det som "1" eftersom att listor börjar med 0 men jag vill att vapenalternativen ska vara 1 och 2 istället för 0 och 1. 

            while (weaponChoice < 0 || weaponChoice >= weapons.Count)
            {
                string whatWeapon = Console.ReadLine();
                bool success = int.TryParse(whatWeapon, out weaponChoice);
                if (success == false)
                {
                    Console.WriteLine("Nej skriv en siffra, dummer!\n");
                    Console.WriteLine("(Sword [1] || Gun [2])");
                }
                weaponChoice--;
            }

            return weaponChoice;
        }

        // This method is used to let the user hit the other fighter with their choice of weapons. 
        public void Attack(Fighter target)
        {
            // Attackmeddelande

            int weaponChoice = ChooseWeapon();

            Console.WriteLine($"\n{name} draws his {weapons[weaponChoice].Name} at {target.GetName()}");

            weapons[weaponChoice].Attack(target);
        }
    }
}