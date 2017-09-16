using System;
namespace TexasHoldEm

{
    class Card{
        private string suit;
        private string rank;
        private enum values {Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
         

         public Card(string suit, string rank){
             this.suit = suit;
             this.rank = rank; //Make sure this field is capitilized
         }
         //Setters for Card
         public void setSuit(string suit) {
             this.suit = suit;
         }

         public void setRank(string rank) {
            this.rank = rank;
         }

        //Getters for Card
        public string getSuit() {
            return suit;
        }
        public string getRank(){
            return rank;
        }

        //Using the enum types to give us the card value
        public int getRankValue() {
            values valRank;
            if(Enum.TryParse(rank, out valRank)){
                if(Enum.IsDefined(typeof(values), valRank)){
                    int retString = Int32.Parse(valRank.ToString());
                    return retString;
                }
            }
            return 99;
        }
        public string toString(){
            return "[" + rank + " of " + suit + "]";
        }


    }
}


//Todo implement enum to replace getRankValue