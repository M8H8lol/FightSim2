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

            Arena arena = new Arena();


            arena.Fight(f1, f2);
        }
    }
}

