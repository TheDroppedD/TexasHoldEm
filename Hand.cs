using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm

{
    class Hand{
        private Collection<Card> cards;

        public Hand(Collection<Card> cards){
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