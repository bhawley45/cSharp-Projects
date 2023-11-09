using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();

            //-=-=-=-=-=-=-= Clear Previous -=-=-=-=-=-=-=
            //Clear all players from any previous games
            foreach (var player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            //-=-=-=-=-=-=-= Take Bets -=-=-=-=-=-=-=
            Console.WriteLine("Place your bet!");
            foreach(var player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet) return;  //end the method
                Bets[player] = bet; //Add player and bet to dictionary (definted in Game class)
            }

            //-=-=-=-=-=-=-= Deal cards -=-=-=-=-=-=-=
            for (int i = 0; i < 2;  i++)
            {
                Console.WriteLine("Dealing...");
                foreach (var player in Players)
                {
                    Console.Write($"{player.Name}: ");
                    Dealer.Deal(player.Hand);

                    //Check for Player automatic Blackjack
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine($"Blackjack! {player.Name} wins {Bets[player]}");
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                //Check for Dealer automatic Blackjack
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if(blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }

            //-=-=-=-=-=-=-= Main Gameplay -=-=-=-=-=-=-=
            foreach (var player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("Your cards are:\n");
                    foreach(var card in player.Hand)
                    {
                        //overriden .ToString() method, see Card.cs
                        Console.WriteLine($"-> {card.ToString()}");
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if(busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine($"{player.Name} Busted! You lose your bet of {Bets[player]}. Your balance is now {player.Balance}");
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "yes" ||  answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine($"{entry.Key.Name} won {entry.Value}");
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }

            foreach(var player in Players)
            {
                //Makes bool nullable (allows 3 different values true/false/null)
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine($"{player.Name} won {Bets[player]}");
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine($"Dealer wins {Bets[player]}");
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Play again?");
                var answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }

        public int MyProperty { get; set; }
    }
}
