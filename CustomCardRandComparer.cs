using System;
using System.Collections;
namespace TexasHoldEm {

class CustomerCardRandComparer : IComparer {
    int IComparer.Compare(Object x, Object y) {
        Card c1 = (Card)x;
        Card c2 = (Card)y;
        //getRankValue
        Random rand = new Random();
        int retInt = rand.Next(-5,5);
        return retInt;
    }
}



}