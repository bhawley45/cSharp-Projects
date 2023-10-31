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
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //Play method would make more sence here,
        //but different games will have specific imnplementation, thus 'abstract'
        public abstract void Play();

        //virtual keyword (cqn only exist in abstract class), has implementation but can be overriden
        public virtual void listPlayers()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
