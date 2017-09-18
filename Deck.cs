using System;
using System.Collections.Generic;
namespace TexasHoldEm
{
    class Deck : IComparer<Card>
    {
        //private readonly int Decksize = 52;
        private List<Card> theDeck = new List<Card>();

        //TODO Figure out how to make this better
        private List<string> Cardranks = new List<string>
        {
            "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

        private List<string> Suits = new List<string>  //not used so far
        { 
            "Spades", "Hearts", "Clubs", "Diamonds" 
        };


        public Deck()
        { 
            //Console.WriteLine("Making Deck"); 
            foreach (string Suit in Suits)
            {
                foreach (string Cardrank in Cardranks)
                {
                    Card c1 = new Card(Suit, Cardrank);
                    theDeck.Add(c1);
                }
            }
        }//Done

        public List<Card> getDeck() 
        {
            return theDeck;
        }//Done


        public Card drawCard()
        {
            Card c1 = theDeck[0];
            theDeck.RemoveAt(0);
            //Console.WriteLine(c1.ToString()); //For testing
            return c1;
        }//Done
        

        //Deck needs shuffle method

          public int Compare(Card x, Card y)
        {
            Card c1 = x;
            Card c2 = y;
            //getRankValue
            Random rand = new Random();
            int retInt = rand.Next(-5, 5);
            return retInt;
        }//Done

        public void shuffleDeck()
        {//TODO, replace iMAX with a non "magic number"
            for(int i = 0; i < 10; i++) 
            {
            theDeck.Sort(Compare);
            }
        }//Done
        
    }//Deck
}//Texas Hold Em 
