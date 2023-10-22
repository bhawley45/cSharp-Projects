using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //Constructor
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        //Properties
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
