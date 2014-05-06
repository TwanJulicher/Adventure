using System;

namespace AdventureJourney
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welkom bij Adventure Journey");
            Game_Start();
        }

        static void Game_Start()
        {

            int Menu_Choice;
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("1: Beginnen");
            Console.WriteLine("2: Informatie");
            Console.WriteLine("3: Afsluiten");
            Menu_Choice = int.Parse(Console.ReadLine());

            switch (Menu_Choice)
            {
                case 1:
                    //Adventure_start();
                    break;
                case 2:
                    Console.WriteLine("In Ontwikkeling");
                    Console.ReadLine();
                    Game_Start();
                    break;
                case 3:
                    Console.WriteLine("Totziens!");
                    Console.ReadLine();
                    return;
                default:
                    Console.WriteLine("Ongeldig antwoord.");
                    Console.ReadLine();
                    Game_Start();
                    break;

            }
        }
    }
}
