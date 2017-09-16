using System;
using System.Collections.Generic;
namespace TexasHoldEm
{
    class Deck : IComparer<Card>
    {
        private readonly int deckSize = 52;
        private List<Card> theDeck = new List<Card>();

        /*private enum values {Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
        */
        //TODO Figure out how to make this better
        private List<string> cardRanks = new List<string>{"Two", "Three", "Four", "Five", "Six", "Seven",
                                                                         "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};

        private List<string> suits = new List<string> { "Spades", "Hearts", "Clubs", "Diamonds" };


        public Deck()
        {
            foreach (string suit in suits)
            {
                foreach (string cardRank in cardRanks)
                {
                    Card c1 = new Card(suit, cardRank);
                    //Console.WriteLine(c1.ToString()); //For testing
                    theDeck.Add(c1);
                }
            }
        }

        public int Compare(Card x, Card y)
        {
            Card c1 = x;
            Card c2 = y;
            //getRankValue
            Random rand = new Random();
            int retInt = rand.Next(-5, 5);
            return retInt;
        }


        public Card drawCard()
        {
            Card c1 = theDeck[0];
            theDeck.RemoveAt(0);
            //Console.WriteLine(c1.ToString()); //For testing
            return c1;
        }

        //Deck needs shuffle method

        public void shuffleDeck()
        {
            //shuffles shit,
            /* 
            List<Card> newDeck = new List<Card>(deckSize);
            Random rnd = new Random();
            int i = 0;
            foreach(Card c in theDeck) {
            newDeck[i] = theDeck[rnd.Next(0,52)];
            int i =0
            }
            */
            theDeck.Sort(Compare);
            theDeck.Sort(Compare);
            foreach(Card c in theDeck) {
                Console.WriteLine(c);
            }

        }
    }
}



