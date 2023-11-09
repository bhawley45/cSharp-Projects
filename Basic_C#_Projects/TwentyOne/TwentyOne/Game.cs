using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //abstract keyword makes the class not able to be instantiated
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        // "value" is the default input parameter for shorthand getters and setters
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } 
        public string Name { get; set; }
        

        public abstract void Play();

        public virtual void listPlayers()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
