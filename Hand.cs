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

    }
}