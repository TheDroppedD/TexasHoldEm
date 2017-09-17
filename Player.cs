using System;
using System.Collections.Generic;
using System.Timers;
namespace TexasHoldEm

{
    class Player
    {
        private Hand Phand;
        private int Chips;
        public Boolean isPlaying;
        private int AmountPaid;
        public Boolean isHuman = true;


        public Player()
        {
            Phand = new Hand();
            Chips = 500;
            isPlaying = false;
        }

        public Hand getPhand() 
        {
            return Phand;
        }

        public void setPhand(Hand h) 
        {
            Phand = h;
        }

        public int getAmountPaid() 
        {
            return AmountPaid;
        }

        public int getChips() 
        {
            return Chips;
        }
        
        public void setChips(int Chips) 
        {
            this.Chips += Chips;
        }

        public override string ToString() {
            return "Chips: " + Chips + ", Hand: " + this.getPhand().seeHand();
        }



        public Boolean anteU() 
        {
            //Timer, lights here
            //Console.WriteLine("Inside Ante U"); 
            Console.WriteLine("What is your move?");
            Console.WriteLine("ENTER 1 to Ante, ENTER 2 to Fold");
            string inp = Console.ReadLine();
            switch(inp)
            {
                case "1":
                    return true;
                    break;
                case "2":
                    isPlaying = false;
                    return false;
                default: 
                    Console.WriteLine("Invalid Input, please try again");
                    return anteU(); //runs recursively if input is invalid
            }
            }//Done
        
        public int playerTurn(Boolean inBet)
        {
            //Timer, lights here
            Console.WriteLine("You have: " + this.ToString());
            Console.WriteLine("What is your move?");
            Console.WriteLine("ENTER 1 for Raise, ENTER 2 for Fold, ENTER 3 for Call, ENTER 4 for Check");
            string inp = Console.ReadLine();
            switch(inp)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                if(inBet)
                {
                    Console.WriteLine("You can't check! You must call, fold or raise");
                    
                    return playerTurn(inBet);
                } 
                else 
                {
                    return 4;
                }
                break;
                default:
                    Console.WriteLine("That's not valid input");
                    return playerTurn(inBet);
                    break;
            }
        }//Done

        public void Fold()
        { //not sure if necessary
            //player can no longer move
            isPlaying  = false;

        }//Done
      
        
        public int Raise()
        { //No payment in this function directly?
            Console.WriteLine("What is your move?");
            Console.WriteLine("Enter amount to raise:");
            string inp = Console.ReadLine();
            int amount = Int32.Parse(inp);

            if(amount > Chips) 
            {
                Console.WriteLine("Sorry, you're broke");
                return Raise();
            } 
            else 
            {
                return amount;
            }
        }//Done

        
        public int Pay(int amount)
        {
            Chips -= amount;
            AmountPaid += amount;
            return amount;
        }//Done
    }
}