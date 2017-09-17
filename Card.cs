using System;
namespace TexasHoldEm

{
    class Card
    {
        private string Suit; 
        private string Rank; 
        /* 
        private int _pSuit ;
        public string pSuit {
            get {return _pSuit;}
            set {_pSuit = value;}}
        public string Rank { get; set; }
        */
        private enum Values
        {
            Two = 2, Three, Four, Five, Six,
            Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }        

        public Card(string suit, string rank)
        {
            this.Suit = suit;
            this.Rank = rank; //Make sure this field is capitilized
        }

        public void setSuit(string s) 
        {
            Suit = s;
        }

        public string getSuit() 
        {
            return Suit;
        }

        public void setRank(string s) 
        {
            Rank = s;
        }

        public string getRank() 
        {
            return Rank;
        }

        //Using the enum types to give us the card value
        public int getRankValue()
        {
            Values valRank;
            if (Enum.TryParse(Rank, out valRank))
            {
                if (Enum.IsDefined(typeof(Values), valRank))
                {
                    int retString = Int32.Parse(valRank.ToString());
                    return retString;
                }
            }
            return 99;
        }
        public override string ToString()
        {
            return "[ " + Rank + " of " + Suit + " ]";
        }


    }
}


//Todo implement enum to replace getRankValue