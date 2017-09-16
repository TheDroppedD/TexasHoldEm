using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm {
    class PokerDriver {
        Hand commCards;
        List<Player> players;
        int moneyPot;
        int currentBet;
        int numRounds;
        List<Player> playersInRound;

        public void roundStart(){
            
        }
        static void Main(string[] args) {
            Console.WriteLine("This is WORKING!");
            Deck aDeck = new Deck();
            aDeck.shuffleDeck();
        }
    }
}