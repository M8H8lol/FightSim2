using System;

namespace FightSim2
{
    public class Arena
    {

        private Fighter f1, f2;


        // Creating the fighters inside of Arena so I don't have to refer to them everytime I want to use it in Arena. 
        public void SetFighters(Fighter one, Fighter two)
        {
            f1 = one;
            f2 = two;
        }

        public void Fight()
        {


            // Sätter en killGame bool till false från början så att jag kan göra det till true när jag vill att spelet ska avslutas
            bool killGame = false;

            Console.WriteLine($"{f1.GetName()} ({f1.Hp} HP) VS {f2.GetName()} ({f2.Hp} HP)");

            Console.WriteLine("ARE YOU READY TO FIGHT?!");

            // En while loop som ser till att spelet tar slut om en av karaktärernas [HP] går under 0
            while (f1.Hp > 0 && f2.Hp > 0 && killGame == false)
            {
                f1.Attack(f2);
                f2.Attack(f1);

                Console.WriteLine($"{f1.GetName()} has {f1.Hp} HP || {f2.GetName()} has {f2.Hp} HP");

                // En while loop som ser till att den fortsätter fråga sålänge spelarnas hp är över 0 och att spelaren inte tackar nej till nästa runda
                killGame = NextRound();
            }
            CheckWinner(f1, f2, false);
        }



        // Gör en metod som kollar om det är true eller false att fighters hp är över noll så att spelet kan fortsätta. 
        public bool NextRound()
        {
            bool killG = true;
            if (f1.Hp > 0 && f2.Hp > 0)
            {
                ConsoleKey inputKey = ConsoleKey.K;

                // Creating a while loop that reads the input that the user wrote regarding if they want to continue figthing or not and making it clear from the console so the console looks more clean. 
                while (inputKey != ConsoleKey.Y && inputKey != ConsoleKey.N)
                {
                    Console.WriteLine("Next round? (y/n)");
                    // ConsoleColor originalColor = Console.ForegroundColor;
                    // Console.ForegroundColor = Console.BackgroundColor;
                    inputKey = Console.ReadKey().Key;
                    Console.CursorLeft--;
                    // Console.ForegroundColor = originalColor;
                    if (inputKey == ConsoleKey.Y)
                    {
                        killG = false;
                    }
                    else if (inputKey == ConsoleKey.N)
                    {
                        killG = true;
                    }
                    else
                    {
                        Console.WriteLine("Yes or no idiot \n");
                    }

                }
            }
            return killG;
        }

        // public bool NextRound(Fighter f1, Fighter f2)
        // {
        //     bool killG = false;
        //     if (f1.hp > 0 && f2.hp > 0)
        //     {
        //         string nextRound = "i";
        //         while (nextRound[0] != 'n' && nextRound[0] != 'y')
        //         {
        //             Console.WriteLine("Next round? (y/n)");
        //             nextRound = Console.ReadLine().ToLower();

        //             if (nextRound[0] == 'n')
        //             {
        //                 killG = true;
        //             }
        //             else if (nextRound[0] != 'y')
        //             {
        //                 Console.WriteLine("Yes or no idiot \n");
        //             }
        //         }
        //     }
        //     return killG;
        // }


        // A method that takes the winner of the fight and writes a victory message, or if its a  draw (if both fighters get equal or below 0 on the same hit)
        public void CheckWinner(Fighter f1, Fighter f2, bool killGame)
        {
            // Printar ut meddelanden beroende på vad spelaren väljer att göra eller om en av krigarna dör
            if (killGame)
            {
                Console.WriteLine("Cowards like you have no room here!");
            }
            else if (f1.Hp <= 0 && f2.Hp <= 0)
            {
                Console.WriteLine("DRAW!");
            }
            else if (f1.Hp <= 0)
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