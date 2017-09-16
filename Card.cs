using System;
namespace TexasHoldEm

{
    class Card
    {
        public string suit { get; set; }
        public string rank { get; set; }
        private enum values
        {
            Two = 2, Three, Four, Five, Six,
            Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }


        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank; //Make sure this field is capitilized
        }

        //Using the enum types to give us the card value
        public int getRankValue()
        {
            values valRank;
            if (Enum.TryParse(rank, out valRank))
            {
                if (Enum.IsDefined(typeof(values), valRank))
                {
                    int retString = Int32.Parse(valRank.ToString());
                    return retString;
                }
            }
            return 99;
        }
        public override string ToString()
        {
            return "[" + rank + " of " + suit + "]";
        }


    }
}


//Todo implement enum to replace getRankValue