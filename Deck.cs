using System;
namespace TexasHoldEm

{
    class Deck{
        Collection<Card> theDeck;
        private enum values {Two = 2, Three = 3, Four = 4, Five = 5, Six = 6,
         Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, 
         King = 13, Ace = 14}

         public Deck(Collection<Card> theDeck){
             this.theDeck = theDeck;
         }
         
    }
}