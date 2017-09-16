using System;
namespace TexasHoldEm

{
    class Card{
        private string suit;
        private string rank; //Holds Word (ie; two)
        private enum values {Two = 2, Three, Four, Five, Six,
         Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
         

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
