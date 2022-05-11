using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using Wizardry_.Models;
using Wizardry_.Methods;

namespace Wizardry_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello there! Welcome to the Grand Cup of Wizardry and Magical Beings! Considering this is a tournament held every 100");

            Console.WriteLine(" years it has quite a reputation.");

            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Before we start what is your first name? Press Enter when finished.");

            Player player1 = new Player();

            Player player2 = new Player();

            do
            {
                player1.FirstName = Console.ReadLine();
                player2.FirstName = "Julia";

            }
            while (Console.ReadKey().Key!= ConsoleKey.Enter);

            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);


            Console.WriteLine("Thanks " + player1.FirstName + ", that's a nice first name. What is your last name?");

            do
            {
                player1.LastName = Console.ReadLine();
                player2.LastName = "Nyomo";
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter);

            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Awesome " + player1.FirstName + " " + player1.LastName + ". I'm glad to meet you. Let's see if you're up for the challenge. Your main opponent is " +
                player2.FirstName + " " + player2.LastName);

            Console.WriteLine();

            Console.WriteLine("The point of this game is to make it to the end of the maze before your opponent. Along the way you will run into a ");

            Console.WriteLine("variety of events. These events can be good or bad." + " Depending on the event you may have to fight with your own magic, ");

            Console.WriteLine(" or try and flee from the battle." + " Keep in mind fleeing causes you to backtrack.");

            Dice dice = new Dice();

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine();

            int maze = 0;

            if(maze != 100)
            {
                Console.WriteLine("On with your adventure!");

                Console.WriteLine();

                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey(true);

                int rollNum = Dice.Roll();

                Console.WriteLine($"You rolled a {rollNum}");
            }

            System.Threading.Thread.Sleep(1000);


            Console.ReadKey();

        }
    }
}
