using System;
namespace TexasHoldEm

{
    class Card{
        private string suit;
        private string rank; //Holds Word (ie; two)
        private enum values {Two = 2, Three = 3, Four = 4, Five = 5, Six = 6,
         Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, 
         King = 13, Ace = 14}
         

         public Card(string suit, string rank){
             this.suit = suit;
             this.rank = rank; 
         }//Card()

         //Setters for Card
         public void setSuit(string suit) {
             this.suit = suit;
         }//setSuit

         public void setRank(string rank) {
            this.rank = rank;
         }//setRank

        //Getters for Card
        public string getSuit() {
            return suit;
        }//getSuit()

        public string getRank() {
            return rank;
        }//getRank()
    }
}
