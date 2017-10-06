using System;
using System.Collections.Generic;
namespace TexasHoldEm

{
    class Hand: IComparer
    {
        private List<Card> cards = new List<Card>();
        //private List<string> Suits = new List<string> { "Spades", "Hearts", "Clubs", "Diamonds" };
        private uint distinctscore = 0; //score of the Hand by running it through the PokerAlg
        private readonly int seen = 2; //amount of elements the player is allowed to see
        public Hand()
        {
            cards = new List<Card>();
        }

          public List<Card> getCards() 
        {
            return cards;
        }

        public void add(Card focusCard)
        {
            cards.Add(focusCard);
        }
        public void remove(Card focusCard)
        {
            cards.Remove(focusCard);
        }
        public void setDistinctScore(uint score) 
        {
            distinctscore = score;
        }
         public uint getDistinctScore() 
         {
             return distinctscore;
         }
        public int Compare(Card x, Card y)
        {
            if (x.getRankValue() > y.getRankValue())
            {
                return 1;
            }
            else if (x.getRankValue() < y.getRankValue())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public int compareDScore(Hand x, Hand y)
        {
            if (x.getDistinctScore() < y.getDistinctScore()) {
                return -1;
            } else if(x.getDistinctScore() > y.getDistinctScore() ) {
                return 1;
            } else {
                return 1;
            }
        }

        public string seeHand() {
            string retString = "{ ";
            for(int i = 0; i < seen; i++)
            {
                retString += cards[i] + ", ";
            }
            retString += " }";
            return retString;
        }

        public override string ToString() {
            string retString = "{ ";
            foreach(Card c in cards) {
                retString += c + ", ";
            }
            retString += " }";
            return retString;
        }

        public void sortHand()
         {
            cards.Sort(Compare);
            foreach(Card c in cards) 
            {
                Console.WriteLine(c);
            }
        }
    
    }
}