using System;
using System.Collections.Generic;
namespace TexasHoldEm
{
    class Deck : IComparer<Card>
    {
        private readonly int Decksize = 52;
        private List<Card> Thedeck = new List<Card>();

        /*private enum values {Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
        */
        //TODO Figure out how to make this better
        private List<string> Cardranks = new List<string>{"Two", "Three", "Four", "Five", "Six", "Seven",
                                                                         "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};

        private List<string> Suits = new List<string> { "Spades", "Hearts", "Clubs", "Diamonds" };


        public Deck()
        { 
            Console.WriteLine("Making Deck"); 
            foreach (string Suit in Suits)
            {
                foreach (string Cardrank in Cardranks)
                {
                    Card c1 = new Card(Suit, Cardrank);
                    Thedeck.Add(c1);
                }
            }
        }


        public Card drawCard()
        {
            Card c1 = Thedeck[0];
            Thedeck.RemoveAt(0);
            //Console.WriteLine(c1.ToString()); //For testing
            return c1;
        }
        

        //Deck needs shuffle method

          public int Compare(Card x, Card y)
        {
            Card c1 = x;
            Card c2 = y;
            //getRankValue
            Random rand = new Random();
            int retInt = rand.Next(-5, 5);
            return retInt;
        }

        public void shuffleDeck()
        {//asdasd
            Thedeck.Sort(Compare);
            Thedeck.Sort(Compare);
        }
        
    }//Deck
}//Texas Hold Em 
