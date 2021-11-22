using System;

namespace FightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snowy fighting game");

            Console.WriteLine("f1:");
            Fighter f1 = new Fighter();
            Console.WriteLine("f2:");
            Fighter f2 = new Fighter();

            Console.WriteLine($"{f1.GetName()} ({f1.hp} HP) VS {f2.GetName()} ({f2.hp} HP)");

            Console.WriteLine("ARE YOU READY TO FIGHT?!");


            // f1.SetName();
            bool killGame = false;

            while (f1.hp > 0 && f2.hp > 0 && killGame == false)
            {
                f1.Attack(f2);
                f2.Attack(f1);

                Console.WriteLine($"{f1.GetName()} has {f1.hp} HP || {f2.GetName()} has {f2.hp} HP");

                if (f1.hp > 0 && f2.hp > 0)
                {

                    Console.WriteLine("Next round? (y/n)");

                    // string nextRound = "";
                    // while (nextRound != "n" && nextRound != "y")
                    // {
                    //     nextRound = Console.ReadLine().ToLower();
                    // }
                    string nextRound = Console.ReadLine().ToLower();


                    if (nextRound == "n" || nextRound == "no")
                    {
                        killGame = true;
                    }
                }
            }

            if (killGame)
            {
                Console.WriteLine("cowards like you have no room here!");
            }
            else if (f1.hp <= 0 && f2.hp <= 0)
            {
                Console.WriteLine("DRAW!");
            }
            else if (f1.hp <= 0)
            {
                Console.WriteLine($"{f2.GetName()} won!");
            }
            else
            {
                Console.WriteLine($"{f1.GetName()} won!");
            }

            Console.ReadLine();
        }
    }
}

