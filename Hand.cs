using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm

{
    class Hand{
        private List<Card> cards;
        public Hand(List<Card> cards){
            this.cards = cards;
        }

        public void add(Card focusCard){
            cards.Add(focusCard);
        }
        public void remove(Card focusCard){
            cards.Remove(focusCard);
        }
    
    }
}