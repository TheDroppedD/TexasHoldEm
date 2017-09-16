using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm {
    class PokerDriver {
        Hand Commcards;
        List<Player> Players;
        int Moneypot;
        int Currentbet;
        int Numrounds;
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