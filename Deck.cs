using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm
{
    class Deck{
        Collection<Card> theDeck;
        private enum values {Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
        private Collection<string> suits = new Collection<string>{"Spades","Hearts", "Clubs", "Diamonds"};
        

         public Deck(){
         }
         
        /*
        public void shuffleDeck();
        public Card drawCard();
        public 
         */ 
    }
}