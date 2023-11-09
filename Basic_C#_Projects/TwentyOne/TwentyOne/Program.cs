using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ULTIMATE BlackJack Tourney \nWhat's your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Welcome {playerName}, would you like to start? (y/n)");
            var answer = Console.ReadLine().ToLower();

            if(answer == "y" || answer == "yes" || answer == "yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                //remove player from Player list in Game.cs
                game -= player;
                Console.WriteLine("\nThanks for playing!");
            }
            Console.WriteLine("Feel free to still look around the game studio. Bye for now!");
            Console.ReadKey();
        }
    }
}
