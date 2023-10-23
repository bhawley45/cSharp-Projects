using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Constructor
        public Deck() 
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string suit in Suits) 
            {
                foreach(string face in Faces)
                {
                    Card card = new Card();
                    card.Suit = suit; 
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        
        //Properties
        public List<Card> Cards { get; set; }

        //Methods
        public void Shuffle(int numberOfShuffles = 1)
        {
            for (int i = 0; i < numberOfShuffles; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
        }
    }
}
