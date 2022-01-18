using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a list of video game names.
            //Order the list of games by length of the game name.
            //Use the lambda expression in this exercise as well.
    
            var videoGamesList = new List<string>() { "Metal Gear Solid", "Resident Evil 5", "Elder Scrolls", "Super Smash Bros Melee" };
            var sortedByLength = videoGamesList.OrderBy(num => num.Length); //USED LAMBDA

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Original List:");
            Console.WriteLine("");
            
            foreach (var game in videoGamesList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Name : {game} Letters: {game.Length}");
                Console.WriteLine("--------------------------------------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Press Enter to See List Sorted By Title Length!");
            Console.ReadLine();
            
            foreach (var game in sortedByLength)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Name: {game} Numbers of Letters in Title: {game.Length}");
                Console.WriteLine("--------------------------------------------------------------");               

            }

            Console.ReadLine();
        }
    }
}
