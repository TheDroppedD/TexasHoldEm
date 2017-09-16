using System;
using System.Collections;
namespace TexasHoldEm {

class CustomerCardRankComparer : IComparer {
    int IComparer.Compare(Card x, Card y) {
        Card c1 = (Card)x;
        Card c2 = (Card)y;
        //getRankValue
        if(c1.getRankValue()  < c2.getRankValue()) {
            return -1;
        } else if(c1.getRankValue() > c2.getRankValue()) {
            return 1;
        } else {
            return 0;
        }
    }
}

}