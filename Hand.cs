using System;
using System.Collections.Generic;
namespace TexasHoldEm

{
    class Hand: IComparer<Card> {
        private List<Card> cards;
        private List<string> suits = new List<string> { "Spades", "Hearts", "Clubs", "Diamonds" };
        public Hand(){
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
    }
}

        /*public int suitEqual(){
            int spadeCount = 0;
            int heartCount = 0;
            int clubCount = 0;
            int diamCount = 0;
            
            foreach(Card c1 in cards){
                for(int i = 0; i < 4; i++){
                    if (c1.suit == suits[i]){
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
                    else{}
                }
            }
        }
    }
}

