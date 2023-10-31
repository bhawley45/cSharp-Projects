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
            
            //For each face
            for(int i = 0; i < 13; i++)
            {
                //For each Suit
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    //each enum item has an int component
                    card.Face = (Face)i; 
                    card.Suit = (Suit)j;
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
