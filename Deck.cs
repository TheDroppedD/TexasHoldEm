using System;
using System.Collections.Generic;
namespace TexasHoldEm
{
    class Deck{
        List<Card> theDeck = new List<Card>();
        /*private enum values {Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
        */
        //TODO Figure out how to make this better
        private List<string> cardRanks = new List<string>{"Two", "Three", "Four", "Five", "Six", "Seven",
                                                                         "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};

        private List<string> suits = new List<string>{"Spades","Hearts", "Clubs", "Diamonds"};
        

        public Deck(){
            foreach(string suit in suits){
                foreach(string cardRank in cardRanks){
                     Card c1 = new Card(suit, cardRank);
                     //Console.WriteLine(c1.ToString()); //For testing
                     theDeck.Add(c1);
            }
        }
    }
}
}
