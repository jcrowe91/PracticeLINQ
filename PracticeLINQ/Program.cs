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
            //Metal Gear Solid, Resident Evil, Elder Scrolls, Super Smash Bros Melee
            var videoGamesList = new List<string>() { "Metal Gear Solid", "Resident Evil", "Elder Scrolls", "Super Smash Bros Melee" };
            
            foreach (var game in videoGamesList)
            {
                Console.WriteLine(game.);
            }
        }
    }
}
