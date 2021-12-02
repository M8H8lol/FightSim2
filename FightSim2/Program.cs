using System;

namespace FightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the winter fighting simulator");


            // Skapar två fighters som användaren får välja namnet på
            Console.WriteLine("f1:");
            Fighter f1 = new Fighter();
            Console.WriteLine("f2:");
            Fighter f2 = new Opponent();

            Console.WriteLine($"{f1.GetName()} ({f1.hp} HP) VS {f2.GetName()} ({f2.hp} HP)");

            Console.WriteLine("ARE YOU READY TO FIGHT?!");


            // Sätter en killGame bool till false från början så att jag kan göra det till true när jag vill att spelet ska avslutas
            bool killGame = false;

            // En while loop som ser till att spelet tar slut om en av karaktärernas [HP] går under 0
            while (f1.hp > 0 && f2.hp > 0 && killGame == false)
            {
                f1.Attack(f2);
                f2.Attack(f1);

                Console.WriteLine($"{f1.GetName()} has {f1.hp} HP || {f2.GetName()} has {f2.hp} HP");

                // En while loop som ser till att den fortsätter fråga sålänge spelarnas hp är över 0 och att spelaren inte tackar nej till nästa runda
                if (f1.hp > 0 && f2.hp > 0)
                {

                    Console.WriteLine("Next round? (y/n)");

                    string nextRound = Console.ReadLine().ToLower();

                    if (nextRound == "n" || nextRound == "no" || nextRound == "N")
                    {
                        killGame = true;
                    }
                }
            }


            // Printar ut meddelanden beroende på vad spelaren väljer att göra eller om en av krigarna dör
            if (killGame)
            {
                Console.WriteLine("Cowards like you have no room here!");
            }
            else if (f1.hp <= 0 && f2.hp <= 0)
            {
                Console.WriteLine("DRAW!");
            }
            else if (f1.hp <= 0)
            {
                Console.WriteLine($"Champion {f2.GetName()} won!");
            }
            else
            {
                Console.WriteLine($"Champion {f1.GetName()} won!");
            }

            Console.ReadLine();
        }
    }
}

