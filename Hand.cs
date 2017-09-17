using System;
using System.Collections.Generic;
namespace TexasHoldEm

{
    class Hand: IComparer<Card> {
        private List<Card> cards{ get; set; }
        private List<string> Suits = new List<string> { "Spades", "Hearts", "Clubs", "Diamonds" };
        private uint distinctscore = 0; //score of the Hand by running it through the PokerAlg
        public Hand(){
            cards = new List<Card>();
        }

        public void add(Card focusCard){
            cards.Add(focusCard);
        }
        public void remove(Card focusCard){
            cards.Remove(focusCard);
        }
        public int Compare(Card x, Card y){
            if (x.getRankValue() > y.getRankValue()){
                return 1;
            }
            else if (x.getRankValue() < y.getRankValue()){
                return -1;
            }
            else{
                return 0;
            }
        }

        public List<Card> getCards() {
            return cards;
        }
        /*public int suitEqual(){
            int spadeCount = 0;
            int heartCount = 0;
            int clubCount = 0;
            int diamCount = 0;
            
            foreach(Card c1 in cards){
                for(int i = 0; i < 4; i++){
                    if (c1.Suit == Suits[i]){
                        if (i == 1){
                            spadeCount++;
                        }
                        else if (i == 2){
                            heartCount++;
                        }
                        else if (i == 3){
                            clubCount++;
                        }
                        else if (i == 4){
                            diamCount++;
                        }
                        else{
                            return 98;
                        }
                    }
                }
            }
            return 0;
        }
        */
        public void sortHand() {
            cards.Sort(Compare);
            foreach(Card c in cards) {
                Console.WriteLine(c);
            }
        }

        public void setDistinctScore() {
            PokerAlg pAlg = new PokerAlg();
            uint x = pAlg.makeDistinctScore(cards);
        }
         public uint getDistinctScore() {
             return distinctscore;
         }
      /*   public boolean isRoyalFlush(){
            int count = 0;
            foreach(Card c1 in cards){
                if (c1.}
        } */
    
    }
}