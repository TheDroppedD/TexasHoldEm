using System;
using System.Collections.Generic;
using System.Timers;
namespace TexasHoldEm

{
    class Player{
        private Hand Phand;
        private int Chips = 500;
        Boolean isPlaying = true;
        private int AmountPaid;


        Player(){
            Phand = new Hand();
        }

        public Hand getPhand() {
            return Phand;
        }

        public int getAmountPaid() {
            return AmountPaid;
        }


        public Boolean anteU() {
            //Timer, lights here
            Console.WriteLine("Inside Ante U"); 
            Console.WriteLine("What is your move?");
            Console.WriteLine("ENTER 1 to Ante, ENTER 2 to Fold");
            string inp = Console.ReadLine();
            if(inp == "1") {
                    return true;
                }else{
                    isPlaying = false;
                    return false;
                }
            }
        
        public int playerTurn(Boolean inBet){
            //Timer, lights here
            Console.WriteLine("What is your move?");
            Console.WriteLine("ENTER 1 for Raise, ENTER 2 for Fold, ENTER 3 for Call, ENTER 4 for Check ");
            string inp = Console.ReadLine();
            switch(inp){
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                if(inBet){
                    Console.WriteLine("You can't check! You must call, fold or raise");
                    return playerTurn(inBet);
                }
                    return 4;

            }
            return 98; //error code
        }

        public void Fold(){
            //player can no longer move
            isPlaying  = false;

        }
      
        
        public int Raise(){ //No payment
            Console.WriteLine("What is your move?");
            Console.WriteLine("Enter amount to raise:");
            string inp = Console.ReadLine();
            int amount = Int32.Parse(inp);

            if(amount > Chips) {
                Console.WriteLine("Sorry, you're broke");
                Raise();
                return 97; //error code
            } else {
                return amount;
            }
        }//done

        
        public int Pay(int amount){
            Chips -= amount;
            AmountPaid += amount;
            return amount;
        }


        /* 
        public void bigBlindTurn() {
            //Timer, lights here
            Console.WriteLine("What is your move?");
            Console.WriteLine("ENTER 1 to Raise, ENTER 2 to Fold, ENTER 3 to Call ");
            string inp = Console.ReadLine();
            switch(inp){
                case "1":
                    Raise();
                    break;
                case "2":
                    Fold();
                    break;
                case "3":
                    Call();
                    break;

            }
        }
*/
    }
}