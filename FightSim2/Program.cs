using System;

namespace FightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tried to kept Program.cs as clean and small as possible


            Console.WriteLine("Welcome to the winter fighting simulator");

            // Skapar två fighters som användaren får välja namnet på
            Console.WriteLine("f1:");
            Fighter f1 = new Fighter();
            Console.WriteLine("f2:");
            Fighter f2 = new Opponent();

            Arena arena = new Arena();

            arena.SetFighters(f1, f2);

            arena.Fight();

        }
    }
}

