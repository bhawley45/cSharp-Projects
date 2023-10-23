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
            Deck deck = new Deck();
            int timesShuffled;
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine($"Times shuffled {timesShuffled}");

            //Press any key to continue...
            Console.ReadKey();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int numberOfShuffles = 1)
        {
            timesShuffled = 0;
            for(int i = 0;i<numberOfShuffles; i++)
            {
                timesShuffled++;
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    tempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = tempList;
            }
            return deck;
        }

        ////Method Overloading
        //public static Deck Shuffle(Deck deck, int numberOfShuffles)
        //{
        //    for(int i = 0; i<numberOfShuffles; i++) 
        //    {
        //        Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
