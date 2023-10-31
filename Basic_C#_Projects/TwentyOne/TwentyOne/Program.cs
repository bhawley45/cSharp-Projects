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
            ////Using overloaded operator
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player() { Name = "Bob"};
            //game += player;
            //game -= player;
            
            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadKey();
        }
    }
}
