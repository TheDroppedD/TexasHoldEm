using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm
{
    class Deck{
        Collection<Card> theDeck;
        /*private enum values {Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
        */
        //TODO Figure out how to make this better
        private Collection<string> cardRanks = new Collection<string>{"Two", "Three", "Four", "Five", "Six", "Seven",
                                                                         "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};

        private Collection<string> suits = new Collection<string>{"Spades","Hearts", "Clubs", "Diamonds"};
        

        public Deck(){
            foreach(string suit in suits){
                foreach(string cardRank in cardRanks){
                     Card c1 = new Card(suit, cardRank);
                     theDeck.Add(c1);
                     Console.WriteLine(c1);
                }
            }
        }  
    }
}